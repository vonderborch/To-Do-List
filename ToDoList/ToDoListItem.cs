namespace ToDoList
{
    public class ToDoListItem
    {
        public bool Completed;

        public string Text;

        public ToDoListItem(string text, bool completed = false)
        {
            Completed = completed;
            Text = text;
        }
    }
}
