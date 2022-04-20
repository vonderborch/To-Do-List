namespace ToDoList
{
    public class ToDoListList
    {
        public string Name;

        public bool AutoSave;

        public bool WindowOnTop;

        public bool ExpandAll;

        public int SaveFileVersion = Constants.SaveFileVersion;

        public string ItemsJson;

        public ToDoListList(string name = "")
        {
            Name = name;
            AutoSave = false;
            WindowOnTop = false;
            ExpandAll = true;
        }
    }
}