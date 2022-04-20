using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Newtonsoft.Json;

namespace ToDoList
{
    public partial class ToDoList : Form
    {
        private ToDoListList _list;

        private List<int> _itemIndex;

        private string _filePath = "";

        public ToDoList()
        {
            InitializeComponent();
            _itemIndex = new List<int>();
            _list = new ToDoListList();
            RefreshListBox();
        }

        public ToDoList(string file)
        {
            InitializeComponent();
            _itemIndex = new List<int>();
            _list = new ToDoListList();
            _filePath = file;
            Open(file);
        }

        private void Open(string file)
        {
            var input = File.ReadAllText(file);
            _list = JsonConvert.DeserializeObject<ToDoListList>(input);
            RefreshListBox();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutBox();
            about.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewWindow("");
        }

        private void closeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Singleton.Instance.OpenFiles.Remove(_filePath);
            this.Close();
        }

        private void clearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _list.Items.Clear();
            RefreshListBox();
        }

        private void toggleAllItemsCompletedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < _list.Items.Count; i++)
            {
                _list.Items[i].Completed = true;
            }
            RefreshListBox();
        }

        private void showAllItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _list.ShowCompletedItems = !_list.ShowCompletedItems;
            RefreshListBox();
        }

        private void hideUncompletedItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _list.ShowIncompleteItems = !_list.ShowIncompleteItems;
            RefreshListBox();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newItem = Interaction.InputBox("New Item?", "New Item", "");

            if (!string.IsNullOrWhiteSpace(newItem))
            {
                _list.Items.Add(new ToDoListItem(newItem));
                RefreshListBox();
            }
        }

        private void deleteCurrentItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (todolist_lst.SelectedIndex != -1)
            {
                var actualIndex = _itemIndex[todolist_lst.SelectedIndex];
                _list.Items.RemoveAt(actualIndex);
                RefreshListBox();
            }
        }

        private void RefreshListBox()
        {
            var currentIndex = todolist_lst.SelectedIndex;
            if (_list.AutoSave && !string.IsNullOrWhiteSpace(_list.Name))
            {
                Save();
            }
            enableAutoSaveToolStripMenuItem.Checked = _list.AutoSave;
            toggleToolStripMenuItem.Checked = _list.WindowOnTop;
            this.TopMost = _list.WindowOnTop;
            showAllItemsToolStripMenuItem.Checked = _list.ShowCompletedItems;
            hideUncompletedItemsToolStripMenuItem.Checked = _list.ShowIncompleteItems;

            todolist_lst.Items.Clear();
            _itemIndex.Clear();
            for (var i = 0; i < _list.Items.Count; i++)
            {
                if ((_list.ShowCompletedItems && _list.Items[i].Completed) || (_list.ShowIncompleteItems && !_list.Items[i].Completed))
                {
                    todolist_lst.Items.Add(_list.Items[i].Text, _list.Items[i].Completed);
                    _itemIndex.Add(i);
                }
            }

            var completedPercent = (decimal)0.00;
            if (_list.Items.Count > 0)
            {
                completedPercent = Math.Round((_list.Items.Where(x => x.Completed).Count() / (decimal) _list.Items.Count) * 100, 2);
            }

            totalItems_txt.Text = $"{_list.Items.Count} items ({_itemIndex.Count} visible), {completedPercent}% Completed";
            statsToolStripMenuItem.Text = totalItems_txt.Text;

            if (!string.IsNullOrWhiteSpace(_list.Name))
            {
                this.Text = $"{_list.Name} - {totalItems_txt.Text}";
                listName_txt.Text = $"List: {_list.Name}";
            }

            if (todolist_lst.Items.Count > 0)
            {
                if (currentIndex == 0)
                {
                    todolist_lst.SelectedIndex = 0;
                }
                else
                {
                    var max = todolist_lst.Items.Count - 1;
                    currentIndex = currentIndex > max ? max : currentIndex;
                    todolist_lst.SelectedIndex = currentIndex;
                }
            }
        }

        private void enableAutoSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _list.AutoSave = !_list.AutoSave;
            RefreshListBox();
        }

        private void markAllItemsIncompleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < _list.Items.Count; i++)
            {
                _list.Items[i].Completed = false;
            }
            RefreshListBox();
        }

        private void toggleItemStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < _list.Items.Count; i++)
            {
                _list.Items[i].Completed = !_list.Items[i].Completed;
            }
            RefreshListBox();
        }

        private void openListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog();
            openDialog.Filter = Constants.SupportedFileTypes;
            openDialog.Multiselect = true;
            openDialog.ShowDialog();

            if (openDialog.FileNames.Length == 1 && _list.Items.Count == 0 && string.IsNullOrWhiteSpace(_list.Name))
            {
                Open(openDialog.FileNames[0]);
            }
            else
            {
                for (var i = 0; i < openDialog.FileNames.Length; i++)
                {
                    if (!Singleton.Instance.OpenFiles.Contains(openDialog.FileNames[i]))
                    {
                        OpenNewWindow(openDialog.FileNames[i]);
                    }
                }
            }
        }

        private void saveListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void saveListAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var oldPath = _filePath;
            var oldName = _list.Name;
            _filePath = GetNewFileName();
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
                RefreshListBox();
            }
        }

        private void OpenNewWindow(string file)
        {
            Process.Start(Assembly.GetEntryAssembly().Location, file);
        }

        private void Save()
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
                var output = JsonConvert.SerializeObject(_list);
                File.WriteAllText(_filePath, output);
            }
        }

        private string GetNewFileName()
        {
            var saveFileName = new SaveFileDialog();
            saveFileName.Filter = Constants.SupportedFileTypes;
            saveFileName.ShowDialog();
            return saveFileName.FileName;
        }

        private void toggleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _list.WindowOnTop = !_list.WindowOnTop;
            RefreshListBox();
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

        private void moveCurrentItemUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (todolist_lst.SelectedIndex > -1)
            {
                var selectedIndex = todolist_lst.SelectedIndex;
                var actualIndex = _itemIndex[selectedIndex];
                if (actualIndex > 0 && todolist_lst.SelectedIndex > 0)
                {
                    var actualAboveIndex = _itemIndex[selectedIndex - 1];
                    SwapItems(actualAboveIndex, actualIndex);
                    todolist_lst.SelectedIndex = selectedIndex - 1;
                }
            }
        }

        private void SwapItems(int indexA, int indexB)
        {
            (_list.Items[indexA], _list.Items[indexB]) = (_list.Items[indexB], _list.Items[indexA]);
            RefreshListBox();
        }

        private void moveCurrentItemDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (todolist_lst.SelectedIndex > -1)
            {
                var selectedIndex = todolist_lst.SelectedIndex;
                var actualIndex = _itemIndex[selectedIndex];
                if (actualIndex < _list.Items.Count - 1)
                {
                    var actualBelowIndex = _itemIndex[selectedIndex + 1];
                    SwapItems(actualBelowIndex, actualIndex);
                    todolist_lst.SelectedIndex = selectedIndex + 1;
                }
            }
        }

        private void editCurrentItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (todolist_lst.SelectedIndex > -1)
            {
                var result = Interaction.InputBox("New Text", "Edit Item", todolist_lst.SelectedItem.ToString());
                if (!string.IsNullOrWhiteSpace(result))
                {
                    var actualIndex = _itemIndex[todolist_lst.SelectedIndex];
                    _list.Items[actualIndex].Text = result;
                    RefreshListBox();
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editCurrentItemToolStripMenuItem_Click(sender, e);
        }

        private void addNewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addItemToolStripMenuItem_Click(sender, e);
        }

        private void deleteCurrentItemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            deleteCurrentItemToolStripMenuItem_Click(sender, e);
        }

        private void todolist_lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (todolist_lst.SelectedIndex > -1)
            {
                var actualIndex = _itemIndex[todolist_lst.SelectedIndex];
                var newState = todolist_lst.GetItemChecked(todolist_lst.SelectedIndex);
                if (_list.Items[actualIndex].Completed != newState)
                {
                    _list.Items[actualIndex].Completed = newState;
                    RefreshListBox();
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            moveCurrentItemUpToolStripMenuItem_Click(sender, e);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            moveCurrentItemDownToolStripMenuItem_Click(sender, e);
        }

        private void addNewChildItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
