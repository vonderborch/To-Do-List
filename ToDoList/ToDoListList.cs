using System.Drawing;

namespace ToDoList
{
    public class ToDoListList
    {
        public bool AutoSave;

        public FontStyle CheckedFontStyle = FontStyle.Strikeout;

        public bool ExpandAll;

        public int FontSize = 10;

        public FontStyle FontStyle = FontStyle.Regular;

        public string ItemsJson;
        public string Name;

        public int SaveFileVersion = Constants.SaveFileVersion;

        public bool WindowOnTop;

        public ToDoListList(string name = "")
        {
            this.Name = name;
            this.AutoSave = false;
            this.WindowOnTop = false;
            this.ExpandAll = true;
        }
    }
}
