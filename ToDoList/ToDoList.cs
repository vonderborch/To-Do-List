using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Velentr.Miscellaneous;

namespace ToDoList
{
    public partial class ToDoList : Form
    {
        private ToDoListList _list;

        private string _filePath = "";

        public Guard _countDirty = new Guard();

        public ToDoList()
        {
            InitializeComponent();
            ExtraInitialization();
            RefreshAndSave();
        }

        public ToDoList(string file)
        {
            InitializeComponent();
            ExtraInitialization();
            _filePath = file;
            Open(file);
            RefreshAndSave();
        }

        public void ExtraInitialization()
        {
            _list = new ToDoListList();
            _countDirty.MarkChecked();
            this.inputText_txt.KeyUp += InputText_txtOnKeyUp;
            this.todolist_lst.AfterCheck += itemChecked_AfterCheck;
        }

        public void OpenNewWindow(string file)
        {
            Process.Start(Assembly.GetEntryAssembly().Location, file);
        }

        public void RefreshAndSave()
        {
            // Save
            if (_list.AutoSave && (!string.IsNullOrWhiteSpace(_list.Name) || todolist_lst.Nodes.Count > 0))
            {
                Save();
            }

            // Refresh list view
            todolist_lst.Refresh();
            if (_list.ExpandAll)
            {
                todolist_lst.ExpandAll();
            }
            else
            {
                todolist_lst.CollapseAll();
            }

            // Update toggles
            enableAutoSaveToolStripMenuItem.Checked = _list.AutoSave;
            if (toggleToolStripMenuItem.Checked != _list.WindowOnTop)
            {
                this.TopMost = _list.WindowOnTop;
            }
            toggleToolStripMenuItem.Checked = _list.WindowOnTop;

            // Calculate stats
            if (_countDirty.Check)
            {
                var completedPercent = (decimal)0.00;
                var completedItemCount = GetTotalCount(true);
                var totalItems = GetTotalCount(false);
                if (totalItems > 0)
                {
                    completedPercent = Math.Round((completedItemCount / (decimal)totalItems) * 100, 2);
                }

                totalItems_txt.Text = $"{totalItems} items ({todolist_lst.Nodes.Count} visible), {completedPercent}% Completed ({completedItemCount}/{totalItems})";

                _countDirty.Reset();
            }

            if (!string.IsNullOrWhiteSpace(_list.Name))
            {
                this.Text = $"{_list.Name} - {totalItems_txt.Text}";
                listName_txt.Text = $"{_list.Name}";
            }
        }

        public int GetTotalCount(bool countOnlyCheckedItems)
        {
            var count = 0;
            for (var i = 0; i < todolist_lst.Nodes.Count; i++)
            {
                count += GetTotalCountHelper(todolist_lst.Nodes[i], countOnlyCheckedItems);
            }

            return count;
        }

        public int GetTotalCountHelper(TreeNode node, bool countOnlyCheckedItems)
        {
            var count = !countOnlyCheckedItems
                ? 1
                : node.Checked
                    ? 1
                    : 0;

            for (var i = 0; i < node.Nodes.Count; i++)
            {
                count += GetTotalCountHelper(node.Nodes[i], countOnlyCheckedItems);
            }

            return count;
        }

        public bool GetInput(string prompt, string title, string defaultResponse, out string output)
        {
            if (string.IsNullOrWhiteSpace(inputText_txt.Text))
            {
                output = Interaction.InputBox(prompt, title, defaultResponse);
            }
            else
            {
                output = inputText_txt.Text;
                inputText_txt.Text = string.Empty;
            }

            return !string.IsNullOrWhiteSpace(output);
        }

        public void SwapItems(int indexA, int indexB, TreeNodeCollection nodes)
        {
            var selectedIsIndexA = nodes[indexA] == todolist_lst.SelectedNode;

            var nodeA = CopyNode(nodes[indexA]);
            nodes.Insert(indexB, nodeA);
            nodes.RemoveAt(indexA + 1);
            if (selectedIsIndexA)
            {
                todolist_lst.SelectedNode = nodeA;
            }
        }

        public TreeNode CreateNode(string text, bool isChecked)
        {
            return new TreeNode(text)
            {
                Checked = isChecked
            };
        }

        public TreeNode CopyNode(TreeNode oldNode)
        {
            return new TreeNode(oldNode.Text)
            {
                Checked = oldNode.Checked
            };
        }

        public void ChangeItemState(TreeNode node, bool? newState)
        {
            node.Checked = newState ?? !node.Checked;

            for (var i = 0; i < node.Nodes.Count; i++)
            {
                ChangeItemState(node.Nodes[i], newState);
            }
        }

        private string GetNewFileName()
        {
            var saveFileName = new SaveFileDialog();
            saveFileName.Filter = Constants.SupportedFileTypes;
            saveFileName.ShowDialog();
            return saveFileName.FileName;
        }

        public void Save()
        {
            if (string.IsNullOrWhiteSpace(_list.Name))
            {
                _filePath = GetNewFileName();
                var name = Path.GetFileNameWithoutExtension(_filePath);

                _list.Name = name;
                _list.AutoSave = true;
            }

            if (!string.IsNullOrWhiteSpace(_filePath))
            {
                var treeView = SerializeTreeView();
                _list.ItemsJson = treeView;
                var output = JsonConvert.SerializeObject(_list);

                while (Singleton.Instance.SaveGuard.CheckSet)
                {
                    Thread.Sleep(50);
                }
                File.WriteAllText(_filePath, output);
                Singleton.Instance.SaveGuard.Reset();
            }
        }

        public void Open(string file)
        {
            var input = File.ReadAllText(file);
            var list = JsonConvert.DeserializeObject<ToDoListList>(input);
            if (list.SaveFileVersion == Constants.SaveFileVersion)
            {
                _list = list;
                DeserializeTreeView(_list.ItemsJson);
            }
            else
            {
                // TODO when I upgrade save file versions :) 
            }

            RefreshAndSave();
        }

        public string SerializeTreeView()
        {
            var nodes = new List<TreeNodeItem>();
            for (var i = 0; i < todolist_lst.Nodes.Count; i++)
            {
                nodes.Add(SerializerHelper(todolist_lst.Nodes[i]));
            }

            return JsonConvert.SerializeObject(nodes);
        }

        public TreeNodeItem SerializerHelper(TreeNode node)
        {
            var newItem = new TreeNodeItem(node.Text, node.Checked);
            for (var i = 0; i < node.Nodes.Count; i++)
            {
                newItem.Children.Add(SerializerHelper(node.Nodes[i]));
            }

            return newItem;
        }

        public void DeserializeTreeView(string serializedData)
        {
            var deserializedNodes = JsonConvert.DeserializeObject<List<TreeNodeItem>>(serializedData);
            for (var i = 0; i < deserializedNodes?.Count; i++)
            {
                DeserializerHelper(todolist_lst.Nodes, deserializedNodes[i]);
            }
        }

        public void DeserializerHelper(TreeNodeCollection nodes, TreeNodeItem item)
        {
            var node = CreateNode(item.Text, item.Checked);
            for (var i = 0; i < item.Children.Count; i++)
            {
                DeserializerHelper(node.Nodes, item.Children[i]);
            }

            nodes.Add(node);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewWindow("");
        }

        private void openListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog
            {
                Filter = Constants.SupportedFileTypes,
                Multiselect = true
            };
            openDialog.ShowDialog();

            if (openDialog.FileNames.Length == 1 && todolist_lst.Nodes.Count == 0 && string.IsNullOrWhiteSpace(_list.Name))
            {
                Open(openDialog.FileNames[0]);
            }
            else
            {
                for (var i = 0; i < openDialog.FileNames.Length; i++)
                {
                    if (openDialog.FileNames[i] != _filePath)
                    {
                        OpenNewWindow(openDialog.FileNames[i]);
                    }
                }
            }
        }

        private void openListInCurrentWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog
            {
                Filter = Constants.SupportedFileTypes,
                Multiselect = false
            };
            openDialog.ShowDialog();

            if (!string.IsNullOrWhiteSpace(openDialog.FileName))
            {
                if (todolist_lst.Nodes.Count > 0 && string.IsNullOrWhiteSpace(_list.Name))
                {
                    Save();
                }
                else if (!string.IsNullOrWhiteSpace(_list.Name) && _list.AutoSave)
                {
                    Save();
                }

                todolist_lst.Nodes.Clear();
                Open(openDialog.FileName);
            }
        }

        private void saveListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void saveListAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var oldPath = _filePath;
            _filePath = GetNewFileName();
            if (!string.IsNullOrWhiteSpace(_filePath))
            {
                var oldName = _list.Name;
                var name = Path.GetFileNameWithoutExtension(_filePath);
                _list.Name = name;
                Save();
                if (!string.IsNullOrWhiteSpace(oldName))
                {
                    OpenNewWindow(_filePath);
                    _filePath = oldPath;
                    _list.Name = oldName;
                }
                else
                {
                    RefreshAndSave();
                }
            }
            else
            {
                _filePath = oldPath;
            }
        }

        private void enableAutoSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _list.AutoSave = !_list.AutoSave;
            RefreshAndSave();
        }

        private void closeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_list.AutoSave)
            {
                Save();
            }
            this.Close();
        }

        private void clearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            todolist_lst.Nodes.Clear();
            RefreshAndSave();
        }

        private void toggleAllItemsCompletedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < todolist_lst.Nodes.Count; i++)
            {
                ChangeItemState(todolist_lst.Nodes[i], true);
            }
            RefreshAndSave();
        }

        private void markAllItemsIncompleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < todolist_lst.Nodes.Count; i++)
            {
                ChangeItemState(todolist_lst.Nodes[i], false);
            }
            RefreshAndSave();
        }

        private void toggleItemStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < todolist_lst.Nodes.Count; i++)
            {
                ChangeItemState(todolist_lst.Nodes[i], null);
            }
            RefreshAndSave();
        }

        private void toggleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _list.WindowOnTop = !_list.WindowOnTop;
            RefreshAndSave();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutBox();
            about.ShowDialog();
        }

        private void reportBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Constants.IssueAndFeatureRequestPage);
            }
            catch
            {
                Interaction.MsgBox($"Please go to {Constants.IssueAndFeatureRequestPage} to file a bug or request a new feature!");
            }
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var latestReleaseTask = Singleton.Instance.Client.Repository.Release.GetLatest(Constants.GithubOwner, Constants.GithubRepo);
            if (latestReleaseTask.Wait(10000))
            {
                var result = latestReleaseTask.Result;
                if (Version.TryParse(result.Name, out var latestVersion))
                {
                    if (latestVersion > Assembly.GetEntryAssembly().GetName().Version)
                    {
                        try
                        {
                            Interaction.MsgBox("A new version is available!");
                            Process.Start(Constants.NewVersionPage);
                        }
                        catch
                        {
                            Interaction.MsgBox($"Please go to {Constants.IssueAndFeatureRequestPage} to download the latest version!");
                        }
                    }
                    else
                    {
                        Interaction.MsgBox("You are running the latest version!");
                    }
                }
                else
                {
                    Interaction.MsgBox($"Latest version can't be parsed, please go to {Constants.NewVersionPage} to check the version!", MsgBoxStyle.Critical);
                }
            }
            else
            {
                Interaction.MsgBox("Timed out while trying to get latest release!", MsgBoxStyle.Critical);
            }
        }

        private void toggleExpandAllItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _list.ExpandAll = !_list.ExpandAll;
            if (_list.ExpandAll)
            {
                todolist_lst.ExpandAll();
            }
            else
            {
                todolist_lst.CollapseAll();
            }
            RefreshAndSave();
        }

        private void moveCurrentItemUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (todolist_lst.SelectedNode != null)
            {
                var currentPositionNode = todolist_lst.SelectedNode;
                var currentIndex = currentPositionNode.Index;
                var nodes = currentPositionNode.Parent == null ? todolist_lst.Nodes : currentPositionNode.Parent.Nodes;
                var nextIndex = Velentr.Math.MathHelpers.Clamp(currentPositionNode.Index - 1, 0, nodes.Count - 1);

                if (currentIndex != nextIndex)
                {
                    SwapItems(currentIndex, nextIndex, nodes);
                    RefreshAndSave();
                }
            }
        }

        private void moveCurrentItemDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (todolist_lst.SelectedNode != null)
            {
                var currentPositionNode = todolist_lst.SelectedNode;
                var currentIndex = currentPositionNode.Index;
                var nodes = currentPositionNode.Parent == null ? todolist_lst.Nodes : currentPositionNode.Parent.Nodes;
                var nextIndex = Velentr.Math.MathHelpers.Clamp(currentPositionNode.Index + 1, 0, nodes.Count - 1);

                if (currentIndex != nextIndex)
                {
                    SwapItems(nextIndex, currentIndex, nodes);
                    RefreshAndSave();
                }
            }
        }

        private void addNewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GetInput("New Item?", "New Item", "", out var newItem))
            {
                var newNode = CreateNode(newItem, false);
                todolist_lst.Nodes.Add(newNode);

                _countDirty.MarkChecked();
                RefreshAndSave();
            }
        }

        private void addNewChildItemMainStrip_Click(object sender, EventArgs e)
        {
            if (todolist_lst.SelectedNode != null && GetInput("New Child Item?", "New Child Item", "", out var newItem))
            {
                var newNode = CreateNode(newItem, false);
                todolist_lst.SelectedNode.Nodes.Add(newNode);

                _countDirty.MarkChecked();
                RefreshAndSave();
            }
        }

        private void editCurrentItemMainStrip_Click(object sender, EventArgs e)
        {
            if (todolist_lst.SelectedNode != null && GetInput("New Item Text", "Edit Item", todolist_lst.SelectedNode.Text, out var newItem))
            {
                todolist_lst.SelectedNode.Text = newItem;

                RefreshAndSave();
            }
        }

        private void deleteCurrentItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (todolist_lst.SelectedNode != null)
            {
                todolist_lst.Nodes.Remove(todolist_lst.SelectedNode);

                _countDirty.MarkChecked();
                RefreshAndSave();
            }
        }

        private void moveItemUpMainStrip_Click(object sender, EventArgs e)
        {
            moveCurrentItemUpToolStripMenuItem_Click(sender, e);
        }

        private void moveItemDownMainStrip_Click(object sender, EventArgs e)
        {
            moveCurrentItemDownToolStripMenuItem_Click(sender, e);
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addNewItemToolStripMenuItem_Click(sender, e);
        }

        private void addNewChildItemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addNewChildItemMainStrip_Click(sender, e);
        }

        private void editCurrentItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editCurrentItemMainStrip_Click(sender, e);
        }

        private void deleteCurrentItemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            deleteCurrentItemToolStripMenuItem_Click(sender, e);
        }

        private void toggleExpandAllItemsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toggleExpandAllItemsToolStripMenuItem_Click(sender, e);
        }

        private void itemChecked_AfterCheck(object sender, EventArgs e)
        {
            _countDirty.MarkChecked();
        }

        private void itemChecked_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (_list.AutoSave)
            {
                Save();
            }
        }

        private void InputText_txtOnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (todolist_lst.SelectedNode != null)
                {
                    addNewChildItemMainStrip_Click(sender, e);
                }
                else
                {
                    addNewItemToolStripMenuItem_Click(sender, e);
                }
            }
        }

        private void unselectCurrentSelectedItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            todolist_lst.SelectedNode = null;
        }

        private void unselectCurrentItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unselectCurrentSelectedItemToolStripMenuItem_Click(sender, e);
        }
    }
}