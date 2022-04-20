using System.Collections.Generic;

namespace ToDoList
{
    public class ToDoListItem
    {
        public bool Completed;

        public string Text;

        public List<ToDoListItem> Children;

        public ToDoListItem(string text, bool completed = false)
        {
            Completed = completed;
            Text = text;
            Children = new List<ToDoListItem>();
        }
    }
}
