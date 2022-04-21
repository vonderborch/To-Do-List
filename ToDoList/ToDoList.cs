using Microsoft.VisualBasic;
using Newtonsoft.Json;
using SIL.FieldWorks.Common.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
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

        private Guard _countDirty = new Guard();
        private Guard _save = new Guard();
        private Guard _firstLoad = new Guard();
        private Guard _openDialog = new Guard();

        private Font _checkedFont;
        private Font _baseFont;

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
            // basics
            _list = new ToDoListList();
            _countDirty.MarkChecked();

            // events
            this.addItemToolStripMenuItem.Click += new EventHandler(this.addItemToolStripMenuItem_Click);
            this.addNewChildItemMainStrip.Click += new EventHandler(this.addNewChildItemMainStrip_Click);
            this.editCurrentItemMainStrip.Click += new EventHandler(this.editCurrentItemMainStrip_Click);
            this.deleteCurrentItemToolStripMenuItem.Click += new EventHandler(this.deleteCurrentItemToolStripMenuItem_Click);
            this.moveItemUpMainStrip.Click += new EventHandler(this.moveItemUpMainStrip_Click);
            this.moveItemDownMainStrip.Click += new EventHandler(this.moveItemDownMainStrip_Click);
            this.toggleExpandAllItemsToolStripMenuItem1.Click += new EventHandler(this.toggleExpandAllItemsToolStripMenuItem1_Click);
            this.unselectCurrentItemToolStripMenuItem.Click += new EventHandler(this.unselectCurrentItemToolStripMenuItem_Click);
            this.newToolStripMenuItem.Click += new EventHandler(this.newToolStripMenuItem_Click);
            this.openListToolStripMenuItem.Click += new EventHandler(this.openListToolStripMenuItem_Click);
            this.openListInCurrentWindowToolStripMenuItem.Click += new EventHandler(this.openListInCurrentWindowToolStripMenuItem_Click);
            this.saveListToolStripMenuItem.Click += new EventHandler(this.saveListToolStripMenuItem_Click);
            this.saveListAsToolStripMenuItem.Click += new EventHandler(this.saveListAsToolStripMenuItem_Click);
            this.enableAutoSaveToolStripMenuItem.Click += new EventHandler(this.enableAutoSaveToolStripMenuItem_Click);
            this.closeListToolStripMenuItem.Click += new EventHandler(this.closeListToolStripMenuItem_Click); ;
            this.clearListToolStripMenuItem.Click += new EventHandler(this.clearListToolStripMenuItem_Click);
            this.toggleAllItemsCompletedToolStripMenuItem.Click += new EventHandler(this.toggleAllItemsCompletedToolStripMenuItem_Click);
            this.markAllItemsIncompleteToolStripMenuItem.Click += new EventHandler(this.markAllItemsIncompleteToolStripMenuItem_Click);
            this.toggleItemStateToolStripMenuItem.Click += new EventHandler(this.toggleItemStateToolStripMenuItem_Click);
            this.moveCurrentItemUpToolStripMenuItem.Click += new EventHandler(this.moveCurrentItemUpToolStripMenuItem_Click);
            this.moveCurrentItemDownToolStripMenuItem.Click += new EventHandler(this.moveCurrentItemDownToolStripMenuItem_Click);
            this.addNewItemToolStripMenuItem.Click += new EventHandler(this.addNewItemToolStripMenuItem_Click);
            this.addNewChildItemToolStripMenuItem1.Click += new EventHandler(this.addNewChildItemToolStripMenuItem1_Click);
            this.editCurrentItemToolStripMenuItem.Click += new EventHandler(this.editCurrentItemToolStripMenuItem_Click);
            this.deleteCurrentItemToolStripMenuItem1.Click += new EventHandler(this.deleteCurrentItemToolStripMenuItem1_Click);
            this.toggleToolStripMenuItem.Click += new EventHandler(this.toggleToolStripMenuItem_Click);
            this.toggleExpandAllItemsToolStripMenuItem.Click += new EventHandler(this.toggleExpandAllItemsToolStripMenuItem_Click);
            this.unselectCurrentSelectedItemToolStripMenuItem.Click += new EventHandler(this.unselectCurrentSelectedItemToolStripMenuItem_Click);
            this.aboutToolStripMenuItem.Click += new EventHandler(this.aboutToolStripMenuItem_Click);
            this.reportBugToolStripMenuItem.Click += new EventHandler(this.reportBugToolStripMenuItem_Click);
            this.checkForUpdatesToolStripMenuItem.Click += new EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            this.todolist_lst.AfterCheck += new TreeViewEventHandler(this.itemChecked_AfterCheck);
            this.copyCurrentItemToolStripMenuItem.Click += new EventHandler(this.copyCurrentItemToolStripMenuItem_Click);
            this.copyCurrentItemToolStripMenuItem1.Click += new EventHandler(this.copyCurrentItemToolStripMenuItem1_Click);
            this.addChildItemToolStripMenuItem.Click += new EventHandler(this.addChildItemToolStripMenuItem_Click);
            this.copyItemToolStripMenuItem.Click += new EventHandler(this.copyItemToolStripMenuItem_Click);
            this.editItemToolStripMenuItem.Click += new EventHandler(this.editItemToolStripMenuItem_Click);
            this.deleteItemToolStripMenuItem.Click += new EventHandler(this.deleteItemToolStripMenuItem_Click);
            this.moveItemUpToolStripMenuItem.Click += new EventHandler(this.moveItemUpToolStripMenuItem_Click);
            this.moveItemDownToolStripMenuItem.Click += new EventHandler(this.moveItemDownToolStripMenuItem_Click);

            this.inputText_txt.KeyUp += InputText_txtOnKeyUp;
            this.todolist_lst.AfterCheck += itemChecked_AfterCheck;
            this.todolist_lst.AfterSelect += Todolist_lstOnAfterSelect;
            this.todolist_lst.MouseClick += Todolist_lstOnMouseClick;

            // fonts
            _baseFont = todolist_lst.Font;
            _checkedFont = new Font(todolist_lst.Font, FontStyle.Strikeout);
        }

        private void Todolist_lstOnMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var selectedNode = todolist_lst.GetNodeAt(e.Location);
                if (selectedNode != todolist_lst.SelectedNode)
                {
                    todolist_lst.SelectedNode = selectedNode;
                }
            }
        }

        private void Todolist_lstOnAfterSelect(object sender, TreeViewEventArgs e)
        {
            RefreshAndSave();
        }

        public void OpenNewWindow(string file)
        {
            Process.Start(Assembly.GetEntryAssembly().Location, file);
        }

        public void RefreshAndSave()
        {
            // Save
            if (_list.AutoSave && _save.Check && !_firstLoad.Check && (!string.IsNullOrWhiteSpace(_list.Name) || todolist_lst.Nodes.Count > 0))
            {
                Save();
                _save.Reset();
            }

            // Refresh list view
            todolist_lst.Refresh();

            // Update toggles
            enableAutoSaveToolStripMenuItem.Checked = _list.AutoSave;
            if (toggleToolStripMenuItem.Checked != _list.WindowOnTop)
            {
                this.TopMost = _list.WindowOnTop;
            }
            toggleToolStripMenuItem.Checked = _list.WindowOnTop;

            // Calculate stats - overall
            if (_countDirty.Check)
            {
                var completedPercent = (decimal)0.00;
                var completedItemCount = GetTotalCount(todolist_lst.Nodes, true);
                var totalItems = GetTotalCount(todolist_lst.Nodes, false);
                var totalItemsWithParents = GetTotalCount(todolist_lst.Nodes, false, true);
                if (totalItems > 0)
                {
                    completedPercent = Math.Round((completedItemCount / (decimal)totalItems) * 100, 2);
                }

                totalItems_txt.Text = $"{totalItems} items ({totalItemsWithParents} items incl. parents), {completedPercent}% Completed ({completedItemCount}/{totalItems})";

                _countDirty.Reset();
            }

            // Calculate stats - for selected node
            if (todolist_lst.SelectedNode != null)
            {
                var totalItems = GetTotalCount(todolist_lst.SelectedNode.Nodes, false);
                if (totalItems == 0)
                {
                    currentSelectionStats_txt.Text = "No child items for selected node";
                }
                else
                {
                    var completedItemCount = GetTotalCount(todolist_lst.SelectedNode.Nodes, true);

                    var completedPercent = (decimal)0.00;
                    if (totalItems > 0)
                    {
                        completedPercent = Math.Round((completedItemCount / (decimal)totalItems) * 100, 2);
                    }
                    currentSelectionStats_txt.Text = $"{totalItems} child items for selected node, {completedPercent}% Completed ({completedItemCount}/{totalItems})";
                }
            }
            else
            {
                currentSelectionStats_txt.Text = "No item selected!";
            }

            if (!string.IsNullOrWhiteSpace(_list.Name))
            {
                this.Text = $"{_list.Name} - {totalItems_txt.Text}";
                listName_txt.Text = $"{_list.Name}";
            }
        }

        public int GetTotalCount(TreeNodeCollection nodes, bool countOnlyCheckedItems, bool countParentNodes = false)
        {
            var count = 0;
            for (var i = 0; i < nodes.Count; i++)
            {
                count += GetTotalCountHelper(nodes[i], countOnlyCheckedItems, countParentNodes);
            }

            return count;
        }

        public int GetTotalCountHelper(TreeNode node, bool countOnlyCheckedItems, bool countParentNodes)
        {
            var count = 0;
            if ((node.Nodes.Count > 0 && countParentNodes) || (node.Nodes.Count == 0 && ((GetNodeChecked(node) && countOnlyCheckedItems) || !countOnlyCheckedItems)))
            {
                count = 1;
            }

            if (count == 1 || node.Nodes.Count > 0)
            {
                for (var i = 0; i < node.Nodes.Count; i++)
                {
                    count += GetTotalCountHelper(node.Nodes[i], countOnlyCheckedItems, countParentNodes);
                }
            }

            return count;
        }

        public bool GetNodeChecked(TreeNode node)
        {
            return todolist_lst.GetChecked(node) == TriStateTreeView.CheckState.Checked;
        }

        public bool GetInput(string prompt, string title, string defaultResponse, out string output)
        {
            if (string.IsNullOrWhiteSpace(inputText_txt.Text))
            {
                this.ActiveControl = null;
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
            var isExpanded = nodes[indexA].IsExpanded;
            var nodeA = CopyNode(nodes[indexA], out var checkedNodes);
            nodes.Insert(indexB, nodeA);
            nodes.RemoveAt(indexA + 1);
            if (selectedIsIndexA)
            {
                todolist_lst.SelectedNode = nodeA;
            }

            if (isExpanded)
            {
                nodeA.ExpandAll();
            }
            for (var i = 0; i < checkedNodes.Count; i++)
            {
                todolist_lst.SetChecked(checkedNodes[i], TriStateTreeView.CheckState.Checked);
            }
        }

        public TreeNode CreateNode(string text, bool isChecked)
        {
            return new TreeNode(text)
            {
                Checked = isChecked
            };
        }

        public TreeNode CopyNode(TreeNode oldNode, out List<TreeNode> checkedNodes)
        {
            checkedNodes = new List<TreeNode>();

            var node = new TreeNode(oldNode.Text)
            {
                Checked = oldNode.Checked,
                NodeFont = oldNode.Checked ? _checkedFont : _baseFont
            };

            if (node.Checked)
            {
                checkedNodes.Add(node);
            }

            for (var i = 0; i < oldNode.Nodes.Count; i++)
            {
                node.Nodes.Add(CopyNode(oldNode.Nodes[i], out var tmp));
                checkedNodes.AddRange(tmp);
            }

            return node;
        }

        public void ChangeItemState(TreeNode node, bool? newState)
        {
            _firstLoad.MarkChecked();
            node.Checked = newState ?? !node.Checked;
            if (node.Nodes.Count > 0)
            {
                for (var i = 0; i < node.Nodes.Count; i++)
                {
                    ChangeItemState(node.Nodes[i], newState);
                }

                node.NodeFont = todolist_lst.GetChecked(node) == TriStateTreeView.CheckState.Checked ? _checkedFont : _baseFont;
            }
            else
            {
                todolist_lst.SetChecked(node, node.Checked ? TriStateTreeView.CheckState.Checked : TriStateTreeView.CheckState.Unchecked);
                node.NodeFont = node.Checked ? _checkedFont : _baseFont;
            }
            _firstLoad.Reset();
        }

        private string GetNewFileName()
        {
            this.ActiveControl = null;
            _openDialog.MarkChecked();
            var saveFileName = new SaveFileDialog();
            saveFileName.Filter = Constants.SupportedFileTypes;
            saveFileName.ShowDialog();
            _openDialog.Reset();
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
            _firstLoad.MarkChecked();
            var input = File.ReadAllText(file);
            var list = JsonConvert.DeserializeObject<ToDoListList>(input);
            if (list.SaveFileVersion == Constants.SaveFileVersion)
            {
                _filePath = file;
                _list = list;
                DeserializeTreeView(_list.ItemsJson);
            }
            else
            {
                // TODO when I upgrade save file versions :)
            }

            _countDirty.MarkChecked();
            RefreshAndSave();
            todolist_lst.ExpandAll();
            _list.ExpandAll = true;
            _firstLoad.Reset();
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
            var newItem = new TreeNodeItem(node.Text, GetNodeChecked(node));
            for (var i = 0; i < node.Nodes.Count; i++)
            {
                newItem.Children.Add(SerializerHelper(node.Nodes[i]));
            }

            return newItem;
        }

        public void DeserializeTreeView(string serializedData)
        {
            var checkStates = new Dictionary<TreeNode, TriStateTreeView.CheckState>();
            var deserializedNodes = JsonConvert.DeserializeObject<List<TreeNodeItem>>(serializedData);
            for (var i = 0; i < deserializedNodes?.Count; i++)
            {
                DeserializerHelper(todolist_lst.Nodes, deserializedNodes[i], checkStates);
            }

            foreach (var state in checkStates.Where(x => x.Value == TriStateTreeView.CheckState.Unchecked))
            {
                todolist_lst.SetChecked(state.Key, state.Value);
            }
            foreach (var state in checkStates.Where(x => x.Value == TriStateTreeView.CheckState.Checked))
            {
                todolist_lst.SetChecked(state.Key, state.Value);
                state.Key.NodeFont = _checkedFont;
            }
            todolist_lst.Refresh();
        }

        public void DeserializerHelper(TreeNodeCollection nodes, TreeNodeItem item, Dictionary<TreeNode, TriStateTreeView.CheckState> checkStates)
        {
            var node = CreateNode(item.Text, item.Checked);
            TriStateTreeView.CheckState state = item.Checked ? TriStateTreeView.CheckState.Checked : TriStateTreeView.CheckState.Unchecked;
            if (item.Children.Count > 0)
            {
                bool oneChecked = false;
                bool oneUnchecked = false;
                for (var i = 0; i < item.Children.Count; i++)
                {
                    if (item.Children[i].Checked)
                    {
                        oneChecked = true;
                    }
                    if (!item.Children[i].Checked)
                    {
                        oneUnchecked = true;
                    }
                    DeserializerHelper(node.Nodes, item.Children[i], checkStates);
                }

                if (oneUnchecked && oneChecked)
                {
                    state = TriStateTreeView.CheckState.GreyChecked;
                }
            }

            if (state != TriStateTreeView.CheckState.GreyChecked)
            {
                checkStates.Add(node, state);
            }
            nodes.Add(node);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewWindow("");
        }

        private void openListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            _openDialog.MarkChecked();
            var openDialog = new OpenFileDialog
            {
                Filter = Constants.SupportedFileTypes,
                Multiselect = true
            };
            openDialog.ShowDialog();
            _openDialog.Reset();

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
            _save.MarkChecked();
            RefreshAndSave();
        }

        private void toggleAllItemsCompletedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < todolist_lst.Nodes.Count; i++)
            {
                ChangeItemState(todolist_lst.Nodes[i], true);
            }
            _countDirty.MarkChecked();
            RefreshAndSave();
        }

        private void markAllItemsIncompleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < todolist_lst.Nodes.Count; i++)
            {
                ChangeItemState(todolist_lst.Nodes[i], false);
            }
            _countDirty.MarkChecked();
            RefreshAndSave();
        }

        private void toggleItemStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < todolist_lst.Nodes.Count; i++)
            {
                ChangeItemState(todolist_lst.Nodes[i], null);
            }
            _countDirty.MarkChecked();
            RefreshAndSave();
        }

        private void toggleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _list.WindowOnTop = !_list.WindowOnTop;
            RefreshAndSave();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            _openDialog.MarkChecked();
            var about = new AboutBox();
            about.ShowDialog();
            _openDialog.Reset();
        }

        private void reportBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Constants.IssueAndFeatureRequestPage);
            }
            catch
            {
                this.ActiveControl = null;
                _openDialog.MarkChecked();
                Interaction.MsgBox($"Please go to {Constants.IssueAndFeatureRequestPage} to file a bug or request a new feature!");
                _openDialog.Reset();
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
                    _save.MarkChecked();
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
                    _save.MarkChecked();
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
                _save.MarkChecked();
                RefreshAndSave();
            }
        }

        private void addNewChildItemMainStrip_Click(object sender, EventArgs e)
        {
            if (todolist_lst.SelectedNode != null && GetInput("New Child Item?", "New Child Item", "", out var newItem))
            {
                var newNode = CreateNode(newItem, false);
                todolist_lst.SelectedNode.Nodes.Add(newNode);
                if (!todolist_lst.SelectedNode.IsExpanded)
                {
                    todolist_lst.SelectedNode.ExpandAll();
                }

                _countDirty.MarkChecked();
                _save.MarkChecked();
                RefreshAndSave();
            }
        }

        private void editCurrentItemMainStrip_Click(object sender, EventArgs e)
        {
            if (todolist_lst.SelectedNode != null && GetInput("New Item Text", "Edit Item", todolist_lst.SelectedNode.Text, out var newItem))
            {
                todolist_lst.SelectedNode.Text = newItem;

                _save.MarkChecked();
                RefreshAndSave();
            }
        }

        private void deleteCurrentItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (todolist_lst.SelectedNode != null)
            {
                todolist_lst.Nodes.Remove(todolist_lst.SelectedNode);

                _countDirty.MarkChecked();
                _save.MarkChecked();
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

        private void itemChecked_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (!_firstLoad.Check)
            {
                var isChecked = todolist_lst.GetChecked(e.Node);
                var update = false;
                if (isChecked == TriStateTreeView.CheckState.Checked && !e.Node.Checked)
                {
                    e.Node.Checked = true;
                    e.Node.NodeFont = _checkedFont;
                    update = true;
                }
                else if (isChecked == TriStateTreeView.CheckState.Unchecked && e.Node.Checked)
                {
                    e.Node.Checked = false;
                    e.Node.NodeFont = _baseFont;
                    update = true;
                }

                if (update)
                {
                    _countDirty.MarkChecked();
                    _save.MarkChecked();
                    RefreshAndSave();
                }
            }
        }

        private void InputText_txtOnKeyUp(object sender, KeyEventArgs e)
        {
            if (!_openDialog.Check)
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
        }

        private void unselectCurrentSelectedItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            todolist_lst.SelectedNode = null;
        }

        private void unselectCurrentItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unselectCurrentSelectedItemToolStripMenuItem_Click(sender, e);
        }

        private void copyCurrentItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (todolist_lst.SelectedNode != null && GetInput("New Item Text", "Copy Item", todolist_lst.SelectedNode.Text, out var newItem))
            {
                var newNode = CopyNode(todolist_lst.SelectedNode, out var checkedNodes);
                newNode.Text = newItem;
                var nodes = todolist_lst.SelectedNode.Parent == null
                    ? todolist_lst.Nodes
                    : todolist_lst.SelectedNode.Parent.Nodes;
                nodes.Add(newNode);

                for (var i = 0; i < checkedNodes.Count; i++)
                {
                    todolist_lst.SetChecked(checkedNodes[i], TriStateTreeView.CheckState.Checked);
                }

                _countDirty.MarkChecked();
                _save.MarkChecked();
                RefreshAndSave();
            }
        }

        private void copyCurrentItemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            copyCurrentItemToolStripMenuItem_Click(sender, e);
        }

        private void addChildItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addNewChildItemToolStripMenuItem1_Click(sender, e);
        }

        private void copyItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyCurrentItemToolStripMenuItem1_Click(sender, e);
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editCurrentItemToolStripMenuItem_Click(sender, e);
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteCurrentItemToolStripMenuItem1_Click(sender, e);
        }

        private void moveItemUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moveItemUpMainStrip_Click(sender, e);
        }

        private void moveItemDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moveItemDownMainStrip_Click(sender, e);
        }
    }
}