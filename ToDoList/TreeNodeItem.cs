using System.Collections.Generic;

namespace ToDoList
{
    public struct TreeNodeItem
    {
        public string Text;
        public bool Checked;
        public List<TreeNodeItem> Children;

        public TreeNodeItem(string text, bool isChecked)
        {
            Text = text;
            Checked = isChecked;
            Children = new List<TreeNodeItem>();
        }
    }
}