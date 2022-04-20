using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            RefreshListBox();
        }

        private void Open(string file)
        {
            var input = File.ReadAllText(file);
            _list = JsonConvert.DeserializeObject<ToDoListList>(input);
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
            showAllItemsToolStripMenuItem.Checked = _list.ShowCompletedItems;
            hideUncompletedItemsToolStripMenuItem.Checked = _list.ShowIncompleteItems;

            todolist_lst.Items.Clear();
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

            for (var i = 0; i < openDialog.FileNames.Length; i++)
            {
                if (!Singleton.Instance.OpenFiles.Contains(openDialog.FileNames[i]))
                {
                    OpenNewWindow(openDialog.FileNames[i]);
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
        }

        private void OpenNewWindow(string file)
        {
            var newWindow = new ToDoList(file);
            newWindow.Show();
            Singleton.Instance.OpenFiles.Add(file);
        }

        private void Save()
        {
            if (_list.Items.Count > 0)
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
        }

        private string GetNewFileName()
        {
            var saveFileName = new SaveFileDialog();
            saveFileName.Filter = Constants.SupportedFileTypes;
            saveFileName.ShowDialog();
            return saveFileName.FileName;
        }
    }
}
