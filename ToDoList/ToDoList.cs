using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

using Microsoft.VisualBasic;

using Newtonsoft.Json;

using SIL.FieldWorks.Common.Controls;

using Velentr.Math;
using Velentr.Miscellaneous;

namespace ToDoList
{
    public partial class ToDoList : Form
    {
        private readonly Guard _countDirty = new Guard();
        private readonly Guard _firstLoad = new Guard();
        private readonly Guard _openDialog = new Guard();
        private readonly Guard _save = new Guard();
        private Font _baseFont;
        private Font _checkedFont;

        private string _filePath = "";
        private ToDoListList _list;

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
            this._filePath = file;
            Open(file);
            RefreshAndSave();
        }

        public void ExtraInitialization()
        {
            // basics
            this._list = new ToDoListList();
            this._countDirty.MarkChecked();

            //// events

            // Add New Item
            this.addItemToolStripMenuItem.Click += AddNewItem;
            this.addNewItemToolStripMenuItem.Click += AddNewItem;

            // Add New Child Item
            this.addNewChildItemMainStrip.Click += AddNewChildItem;
            this.addNewChildItemToolStripMenuItem1.Click += AddNewChildItem;
            this.addChildItemToolStripMenuItem.Click += AddNewChildItem;

            // Edit Current Item
            this.editCurrentItemMainStrip.Click += EditCurrentItem;
            this.editCurrentItemToolStripMenuItem.Click += EditCurrentItem;
            this.editItemToolStripMenuItem.Click += EditCurrentItem;

            // Delete Current Item
            this.deleteCurrentItemToolStripMenuItem.Click += DeleteCurrentItem;
            this.deleteCurrentItemToolStripMenuItem1.Click += DeleteCurrentItem;
            this.deleteItemToolStripMenuItem.Click += DeleteCurrentItem;

            // Copy Current Item

            // Paste Item to Top

            // Paste Item to Bottom

            // Paste Item Above

            // Paste Item Below

            // Duplicate Current Item to Top of Parent Node
            this.duplicateToTop_btn.Click += DuplicateCurrentItemToTopOfParent;
            this.duplicateItemToTop_btn.Click += DuplicateCurrentItemToTopOfParent;

            // Duplicate Current Item to Bottom of Parent Node
            this.copyCurrentItemToolStripMenuItem1.Click += DuplicateCurrentItemToBottomOfParent;
            this.copyItemToolStripMenuItem.Click += DuplicateCurrentItemToBottomOfParent;

            // Move Item to Top
            this.moveItemToTop_btn.Click += MoveItemTop;
            this.toTop_btn.Click += MoveItemTop;
            this.currentItemToTop_btn.Click += MoveItemTop;

            // Move Item Up
            this.moveItemUpMainStrip.Click += MoveItemUp;
            this.moveCurrentItemUpToolStripMenuItem.Click += MoveItemUp;
            this.moveItemUpToolStripMenuItem.Click += MoveItemUp;

            // Move Item Down
            this.moveItemDownMainStrip.Click += MoveItemDown;
            this.moveCurrentItemDownToolStripMenuItem.Click += MoveItemDown;
            this.moveItemDownToolStripMenuItem.Click += MoveItemDown;

            // Move Item to Bottom
            this.moveItemToBottomToolStripMenuItem.Click += MoveItemBottom;
            this.toBottom_btn.Click += MoveItemTop;
            this.currentItemToTop_btn.Click += MoveItemTop;

            // Deselect Current Item
            this.unselectCurrentItemToolStripMenuItem.Click += DeselectCurrentItem;
            this.unselectCurrentSelectedItemToolStripMenuItem.Click += DeselectCurrentItem;

            // Clear List
            this.clearListToolStripMenuItem.Click += ClearList;

            // Mark All Items Completed
            this.toggleAllItemsCompletedToolStripMenuItem.Click += MarkAllItemsCompleted;

            // Mark All Items Incomplete
            this.markAllItemsIncompleteToolStripMenuItem.Click += MarkAllItemsIncomplete;

            // Toggle All Items
            this.toggleItemStateToolStripMenuItem.Click += ToggleAllItemsState;

            // Toggle Expand All Items
            this.toggleExpandAllItemsToolStripMenuItem1.Click += ToggleSeeAllItems;
            this.toggleExpandAllItemsToolStripMenuItem.Click += ToggleSeeAllItems;

            // New List
            this.newToolStripMenuItem.Click += NewList;

            // Open List
            this.openListToolStripMenuItem.Click += OpenList;

            // Open List in Current Window
            this.openListInCurrentWindowToolStripMenuItem.Click += OpenListInCurrentWindow;

            // Save List
            this.saveListToolStripMenuItem.Click += SaveList;

            // Save As List
            this.saveListAsToolStripMenuItem.Click += SaveListAs;

            // Toggle Autosave
            this.enableAutoSaveToolStripMenuItem.Click += ToggleAutoSave;

            // Toggle Window on Top
            this.toggleToolStripMenuItem.Click += ToggleWindowOnTop;

            // Close List/Exit
            this.closeListToolStripMenuItem.Click += ExistProgram;

            // Open About Window
            this.aboutToolStripMenuItem.Click += OpenAboutInfo;

            // Report a Bug
            this.reportBugToolStripMenuItem.Click += ReportBug;

            // Check for Updates
            this.checkForUpdatesToolStripMenuItem.Click += CheckForUpdates;

            // List Utility Functions
            this.todolist_lst.AfterCheck += itemChecked_AfterCheck;
            this.inputText_txt.KeyUp += InputText_txtOnKeyUp;
            this.todolist_lst.AfterCheck += itemChecked_AfterCheck;
            this.todolist_lst.AfterSelect += Todolist_lstOnAfterSelect;
            this.todolist_lst.MouseClick += Todolist_lstOnMouseClick;

            // fonts
            this._baseFont = this.todolist_lst.Font;
            this._checkedFont = new Font(this.todolist_lst.Font, FontStyle.Strikeout);
        }

        private void Todolist_lstOnMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var selectedNode = this.todolist_lst.GetNodeAt(e.Location);
                if (selectedNode != this.todolist_lst.SelectedNode)
                {
                    this.todolist_lst.SelectedNode = selectedNode;
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
            if (this._list.AutoSave && this._save.Check && !this._firstLoad.Check && (!string.IsNullOrWhiteSpace(this._list.Name) || this.todolist_lst.Nodes.Count > 0))
            {
                Save();
                this._save.Reset();
            }

            // Refresh list view
            this.todolist_lst.Refresh();

            // Update toggles
            this.enableAutoSaveToolStripMenuItem.Checked = this._list.AutoSave;
            if (this.toggleToolStripMenuItem.Checked != this._list.WindowOnTop)
            {
                this.TopMost = this._list.WindowOnTop;
            }

            this.toggleToolStripMenuItem.Checked = this._list.WindowOnTop;

            // Calculate stats - overall
            if (this._countDirty.Check)
            {
                var completedPercent = (decimal) 0.00;
                var completedItemCount = GetTotalCount(this.todolist_lst.Nodes, true);
                var totalItems = GetTotalCount(this.todolist_lst.Nodes, false);
                var totalItemsWithParents = GetTotalCount(this.todolist_lst.Nodes, false, true);
                if (totalItems > 0)
                {
                    completedPercent = Math.Round(completedItemCount / (decimal) totalItems * 100, 2);
                }

                this.totalItems_txt.Text = $"{totalItems} items ({totalItemsWithParents} items incl. parents), {completedPercent}% Completed ({completedItemCount}/{totalItems})";

                this._countDirty.Reset();
            }

            // Calculate stats - for selected node
            if (this.todolist_lst.SelectedNode != null)
            {
                var totalItems = GetTotalCount(this.todolist_lst.SelectedNode.Nodes, false);
                if (totalItems == 0)
                {
                    this.currentSelectionStats_txt.Text = "No child items for selected node";
                }
                else
                {
                    var completedItemCount = GetTotalCount(this.todolist_lst.SelectedNode.Nodes, true);

                    var completedPercent = (decimal) 0.00;
                    if (totalItems > 0)
                    {
                        completedPercent = Math.Round(completedItemCount / (decimal) totalItems * 100, 2);
                    }

                    this.currentSelectionStats_txt.Text = $"{totalItems} child items for selected node, {completedPercent}% Completed ({completedItemCount}/{totalItems})";
                }
            }
            else
            {
                this.currentSelectionStats_txt.Text = "No item selected!";
            }

            if (!string.IsNullOrWhiteSpace(this._list.Name))
            {
                this.Text = $"{this._list.Name} - {this.totalItems_txt.Text}";
                this.listName_txt.Text = $"{this._list.Name}";
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
            return this.todolist_lst.GetChecked(node) == TriStateTreeView.CheckState.Checked;
        }

        public bool GetInput(string prompt, string title, string defaultResponse, out string output)
        {
            if (string.IsNullOrWhiteSpace(this.inputText_txt.Text))
            {
                this.ActiveControl = null;
                output = Interaction.InputBox(prompt, title, defaultResponse);
            }
            else
            {
                output = this.inputText_txt.Text;
                this.inputText_txt.Text = string.Empty;
            }

            return !string.IsNullOrWhiteSpace(output);
        }

        public void SwapItems(int indexA, int indexB, TreeNodeCollection nodes)
        {
            var selectedIsIndexA = nodes[indexA] == this.todolist_lst.SelectedNode;
            var isExpanded = nodes[indexA].IsExpanded;
            var nodeA = CopyNode(nodes[indexA], out var checkedNodes);
            nodes.Insert(indexB, nodeA);
            nodes.RemoveAt(indexA + 1);
            if (selectedIsIndexA)
            {
                this.todolist_lst.SelectedNode = nodeA;
            }

            if (isExpanded)
            {
                nodeA.ExpandAll();
            }

            for (var i = 0; i < checkedNodes.Count; i++)
            {
                this.todolist_lst.SetChecked(checkedNodes[i], TriStateTreeView.CheckState.Checked);
            }
        }

        public TreeNode CreateNode(string text, bool isChecked)
        {
            return new TreeNode(text) {Checked = isChecked};
        }

        public TreeNode CopyNode(TreeNode oldNode, out List<TreeNode> checkedNodes)
        {
            checkedNodes = new List<TreeNode>();

            var node = new TreeNode(oldNode.Text) {Checked = oldNode.Checked, NodeFont = oldNode.Checked ? this._checkedFont : this._baseFont};

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
            this._firstLoad.MarkChecked();
            node.Checked = newState ?? !node.Checked;
            if (node.Nodes.Count > 0)
            {
                for (var i = 0; i < node.Nodes.Count; i++)
                {
                    ChangeItemState(node.Nodes[i], newState);
                }

                node.NodeFont = this.todolist_lst.GetChecked(node) == TriStateTreeView.CheckState.Checked ? this._checkedFont : this._baseFont;
            }
            else
            {
                this.todolist_lst.SetChecked(node, node.Checked ? TriStateTreeView.CheckState.Checked : TriStateTreeView.CheckState.Unchecked);
                node.NodeFont = node.Checked ? this._checkedFont : this._baseFont;
            }

            this._firstLoad.Reset();
        }

        private string GetNewFileName()
        {
            this.ActiveControl = null;
            this._openDialog.MarkChecked();
            var saveFileName = new SaveFileDialog();
            saveFileName.Filter = Constants.SupportedFileTypes;
            saveFileName.ShowDialog();
            this._openDialog.Reset();

            return saveFileName.FileName;
        }

        public void Save()
        {
            if (string.IsNullOrWhiteSpace(this._list.Name))
            {
                this._filePath = GetNewFileName();
                var name = Path.GetFileNameWithoutExtension(this._filePath);

                this._list.Name = name;
                this._list.AutoSave = true;
            }

            if (!string.IsNullOrWhiteSpace(this._filePath))
            {
                var treeView = SerializeTreeView();
                this._list.ItemsJson = treeView;
                var output = JsonConvert.SerializeObject(this._list);

                while (Singleton.Instance.SaveGuard.CheckSet)
                {
                    Thread.Sleep(50);
                }

                File.WriteAllText(this._filePath, output);
                Singleton.Instance.SaveGuard.Reset();
            }
        }

        public void Open(string file)
        {
            this._firstLoad.MarkChecked();
            var input = File.ReadAllText(file);
            var list = JsonConvert.DeserializeObject<ToDoListList>(input);
            if (list.SaveFileVersion == Constants.SaveFileVersion)
            {
                this._filePath = file;
                this._list = list;
                DeserializeTreeView(this._list.ItemsJson);
            }

            this._countDirty.MarkChecked();
            RefreshAndSave();
            this.todolist_lst.ExpandAll();
            this._list.ExpandAll = true;
            this._firstLoad.Reset();
        }

        public string SerializeTreeView()
        {
            var nodes = new List<TreeNodeItem>();
            for (var i = 0; i < this.todolist_lst.Nodes.Count; i++)
            {
                nodes.Add(SerializerHelper(this.todolist_lst.Nodes[i]));
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
                DeserializerHelper(this.todolist_lst.Nodes, deserializedNodes[i], checkStates);
            }

            foreach (var state in checkStates.Where(x => x.Value == TriStateTreeView.CheckState.Unchecked))
            {
                this.todolist_lst.SetChecked(state.Key, state.Value);
            }

            foreach (var state in checkStates.Where(x => x.Value == TriStateTreeView.CheckState.Checked))
            {
                this.todolist_lst.SetChecked(state.Key, state.Value);
                state.Key.NodeFont = this._checkedFont;
            }

            this.todolist_lst.Refresh();
        }

        public void DeserializerHelper(TreeNodeCollection nodes, TreeNodeItem item, Dictionary<TreeNode, TriStateTreeView.CheckState> checkStates)
        {
            var node = CreateNode(item.Text, item.Checked);
            var state = item.Checked ? TriStateTreeView.CheckState.Checked : TriStateTreeView.CheckState.Unchecked;
            if (item.Children.Count > 0)
            {
                var oneChecked = false;
                var oneUnchecked = false;
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

        private void NewList(object sender, EventArgs e)
        {
            OpenNewWindow("");
        }

        private void OpenList(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            this._openDialog.MarkChecked();
            var openDialog = new OpenFileDialog {Filter = Constants.SupportedFileTypes, Multiselect = true};
            openDialog.ShowDialog();
            this._openDialog.Reset();

            if (openDialog.FileNames.Length == 1 && this.todolist_lst.Nodes.Count == 0 && string.IsNullOrWhiteSpace(this._list.Name))
            {
                Open(openDialog.FileNames[0]);
            }
            else
            {
                for (var i = 0; i < openDialog.FileNames.Length; i++)
                {
                    if (openDialog.FileNames[i] != this._filePath)
                    {
                        OpenNewWindow(openDialog.FileNames[i]);
                    }
                }
            }
        }

        private void OpenListInCurrentWindow(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog {Filter = Constants.SupportedFileTypes, Multiselect = false};
            openDialog.ShowDialog();

            if (!string.IsNullOrWhiteSpace(openDialog.FileName))
            {
                if (this.todolist_lst.Nodes.Count > 0 && string.IsNullOrWhiteSpace(this._list.Name))
                {
                    Save();
                }
                else if (!string.IsNullOrWhiteSpace(this._list.Name) && this._list.AutoSave)
                {
                    Save();
                }

                this.todolist_lst.Nodes.Clear();
                Open(openDialog.FileName);
            }
        }

        private void SaveList(object sender, EventArgs e)
        {
            Save();
        }

        private void SaveListAs(object sender, EventArgs e)
        {
            var oldPath = this._filePath;
            this._filePath = GetNewFileName();
            if (!string.IsNullOrWhiteSpace(this._filePath))
            {
                var oldName = this._list.Name;
                var name = Path.GetFileNameWithoutExtension(this._filePath);
                this._list.Name = name;
                Save();
                if (!string.IsNullOrWhiteSpace(oldName))
                {
                    OpenNewWindow(this._filePath);
                    this._filePath = oldPath;
                    this._list.Name = oldName;
                }
                else
                {
                    RefreshAndSave();
                }
            }
            else
            {
                this._filePath = oldPath;
            }
        }

        private void ToggleAutoSave(object sender, EventArgs e)
        {
            this._list.AutoSave = !this._list.AutoSave;
            RefreshAndSave();
        }

        private void ExistProgram(object sender, EventArgs e)
        {
            if (this._list.AutoSave)
            {
                Save();
            }

            Close();
        }

        private void ClearList(object sender, EventArgs e)
        {
            this.todolist_lst.Nodes.Clear();
            this._save.MarkChecked();
            RefreshAndSave();
        }

        private void MarkAllItemsCompleted(object sender, EventArgs e)
        {
            for (var i = 0; i < this.todolist_lst.Nodes.Count; i++)
            {
                ChangeItemState(this.todolist_lst.Nodes[i], true);
            }

            this._countDirty.MarkChecked();
            RefreshAndSave();
        }

        private void MarkAllItemsIncomplete(object sender, EventArgs e)
        {
            for (var i = 0; i < this.todolist_lst.Nodes.Count; i++)
            {
                ChangeItemState(this.todolist_lst.Nodes[i], false);
            }

            this._countDirty.MarkChecked();
            RefreshAndSave();
        }

        private void ToggleAllItemsState(object sender, EventArgs e)
        {
            for (var i = 0; i < this.todolist_lst.Nodes.Count; i++)
            {
                ChangeItemState(this.todolist_lst.Nodes[i], null);
            }

            this._countDirty.MarkChecked();
            RefreshAndSave();
        }

        private void ToggleWindowOnTop(object sender, EventArgs e)
        {
            this._list.WindowOnTop = !this._list.WindowOnTop;
            RefreshAndSave();
        }

        private void OpenAboutInfo(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            this._openDialog.MarkChecked();
            var about = new AboutBox();
            about.ShowDialog();
            this._openDialog.Reset();
        }

        private void ReportBug(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Constants.IssueAndFeatureRequestPage);
            }
            catch
            {
                this.ActiveControl = null;
                this._openDialog.MarkChecked();
                Interaction.MsgBox($"Please go to {Constants.IssueAndFeatureRequestPage} to file a bug or request a new feature!");
                this._openDialog.Reset();
            }
        }

        private void CheckForUpdates(object sender, EventArgs e)
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

        private void ToggleSeeAllItems(object sender, EventArgs e)
        {
            this._list.ExpandAll = !this._list.ExpandAll;
            if (this._list.ExpandAll)
            {
                this.todolist_lst.ExpandAll();
            }
            else
            {
                this.todolist_lst.CollapseAll();
            }

            RefreshAndSave();
        }

        public void MoveItemTop(object sender, EventArgs e)
        {
            if (this.todolist_lst.SelectedNode != null)
            {
                var currentPositionNode = this.todolist_lst.SelectedNode;
                var currentIndex = currentPositionNode.Index;
                var nodes = currentPositionNode.Parent == null ? this.todolist_lst.Nodes : currentPositionNode.Parent.Nodes;

                if (currentIndex != 0)
                {
                    SwapItems(currentIndex, 0, nodes);
                    this._save.MarkChecked();
                    RefreshAndSave();
                }
            }
        }

        private void MoveItemUp(object sender, EventArgs e)
        {
            if (this.todolist_lst.SelectedNode != null)
            {
                var currentPositionNode = this.todolist_lst.SelectedNode;
                var currentIndex = currentPositionNode.Index;
                var nodes = currentPositionNode.Parent == null ? this.todolist_lst.Nodes : currentPositionNode.Parent.Nodes;
                var nextIndex = MathHelpers.Clamp(currentPositionNode.Index - 1, 0, nodes.Count - 1);

                if (currentIndex != nextIndex)
                {
                    SwapItems(currentIndex, nextIndex, nodes);
                    this._save.MarkChecked();
                    RefreshAndSave();
                }
            }
        }

        private void MoveItemDown(object sender, EventArgs e)
        {
            if (this.todolist_lst.SelectedNode != null)
            {
                var currentPositionNode = this.todolist_lst.SelectedNode;
                var currentIndex = currentPositionNode.Index;
                var nodes = currentPositionNode.Parent == null ? this.todolist_lst.Nodes : currentPositionNode.Parent.Nodes;
                var nextIndex = MathHelpers.Clamp(currentPositionNode.Index + 1, 0, nodes.Count - 1);

                if (currentIndex != nextIndex)
                {
                    SwapItems(nextIndex, currentIndex, nodes);
                    this._save.MarkChecked();
                    RefreshAndSave();
                }
            }
        }

        private void MoveItemBottom(object sender, EventArgs e)
        {
            if (this.todolist_lst.SelectedNode != null)
            {
                var currentPositionNode = this.todolist_lst.SelectedNode;
                var currentIndex = currentPositionNode.Index;
                var nodes = currentPositionNode.Parent == null ? this.todolist_lst.Nodes : currentPositionNode.Parent.Nodes;
                var nextIndex = nodes.Count - 1;

                if (currentIndex != nextIndex)
                {
                    SwapItems(nextIndex, currentIndex, nodes);
                    this._save.MarkChecked();
                    RefreshAndSave();
                }
            }
        }

        private void AddNewItem(object sender, EventArgs e)
        {
            if (GetInput("New Item?", "New Item", "", out var newItem))
            {
                var newNode = CreateNode(newItem, false);
                this.todolist_lst.Nodes.Add(newNode);

                this._countDirty.MarkChecked();
                this._save.MarkChecked();
                RefreshAndSave();
            }
        }

        private void AddNewChildItem(object sender, EventArgs e)
        {
            if (this.todolist_lst.SelectedNode != null && GetInput("New Child Item?", "New Child Item", "", out var newItem))
            {
                var newNode = CreateNode(newItem, false);
                this.todolist_lst.SelectedNode.Nodes.Add(newNode);
                if (!this.todolist_lst.SelectedNode.IsExpanded)
                {
                    this.todolist_lst.SelectedNode.ExpandAll();
                }

                this._countDirty.MarkChecked();
                this._save.MarkChecked();
                RefreshAndSave();
            }
        }

        private void EditCurrentItem(object sender, EventArgs e)
        {
            if (this.todolist_lst.SelectedNode != null && GetInput("New Item Text", "Edit Item", this.todolist_lst.SelectedNode.Text, out var newItem))
            {
                this.todolist_lst.SelectedNode.Text = newItem;

                this._save.MarkChecked();
                RefreshAndSave();
            }
        }

        private void DeleteCurrentItem(object sender, EventArgs e)
        {
            if (this.todolist_lst.SelectedNode != null)
            {
                this.todolist_lst.Nodes.Remove(this.todolist_lst.SelectedNode);

                this._countDirty.MarkChecked();
                this._save.MarkChecked();
                RefreshAndSave();
            }
        }

        private void itemChecked_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (!this._firstLoad.Check)
            {
                var isChecked = this.todolist_lst.GetChecked(e.Node);
                var update = false;
                if (isChecked == TriStateTreeView.CheckState.Checked && !e.Node.Checked)
                {
                    e.Node.Checked = true;
                    e.Node.NodeFont = this._checkedFont;
                    update = true;
                }
                else if (isChecked == TriStateTreeView.CheckState.Unchecked && e.Node.Checked)
                {
                    e.Node.Checked = false;
                    e.Node.NodeFont = this._baseFont;
                    update = true;
                }

                if (update)
                {
                    this._countDirty.MarkChecked();
                    this._save.MarkChecked();
                    RefreshAndSave();
                }
            }
        }

        private void InputText_txtOnKeyUp(object sender, KeyEventArgs e)
        {
            if (!this._openDialog.Check)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (this.todolist_lst.SelectedNode != null)
                    {
                        AddNewChildItem(sender, e);
                    }
                    else
                    {
                        AddNewItem(sender, e);
                    }
                }
            }
        }

        private void DeselectCurrentItem(object sender, EventArgs e)
        {
            this.todolist_lst.SelectedNode = null;
        }

        public void DuplicateCurrentItemToTopOfParent(object sender, EventArgs e)
        {
            if (this.todolist_lst.SelectedNode != null && GetInput("New Item Text", "Copy Item", this.todolist_lst.SelectedNode.Text, out var newItem))
            {
                var newNode = CopyNode(this.todolist_lst.SelectedNode, out var checkedNodes);
                newNode.Text = newItem;
                var nodes = this.todolist_lst.SelectedNode.Parent == null ? this.todolist_lst.Nodes : this.todolist_lst.SelectedNode.Parent.Nodes;
                nodes.Add(newNode);

                for (var i = 0; i < checkedNodes.Count; i++)
                {
                    this.todolist_lst.SetChecked(checkedNodes[i], TriStateTreeView.CheckState.Checked);
                }

                SwapItems(nodes.Count - 1, 0, nodes);
                this._countDirty.MarkChecked();
                this._save.MarkChecked();
                RefreshAndSave();
            }
        }

        private void DuplicateCurrentItemToBottomOfParent(object sender, EventArgs e)
        {
            if (this.todolist_lst.SelectedNode != null && GetInput("New Item Text", "Copy Item", this.todolist_lst.SelectedNode.Text, out var newItem))
            {
                var newNode = CopyNode(this.todolist_lst.SelectedNode, out var checkedNodes);
                newNode.Text = newItem;
                var nodes = this.todolist_lst.SelectedNode.Parent == null ? this.todolist_lst.Nodes : this.todolist_lst.SelectedNode.Parent.Nodes;
                nodes.Add(newNode);

                for (var i = 0; i < checkedNodes.Count; i++)
                {
                    this.todolist_lst.SetChecked(checkedNodes[i], TriStateTreeView.CheckState.Checked);
                }

                this._countDirty.MarkChecked();
                this._save.MarkChecked();
                RefreshAndSave();
            }
        }
    }
}
