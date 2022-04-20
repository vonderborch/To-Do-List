using System.Collections.Generic;

namespace ToDoList
{
    public class ToDoListList
    {
        public string Name;

        public List<ToDoListItem> Items;

        public bool ShowCompletedItems;

        public bool ShowIncompleteItems;

        public bool AutoSave;

        public bool WindowOnTop;

        public ToDoListList(string name = "")
        {
            Name = name;
            Items = new List<ToDoListItem>();
            ShowCompletedItems = true;
            ShowIncompleteItems = true;
            AutoSave = false;
            WindowOnTop = false;
        }
    }
}
