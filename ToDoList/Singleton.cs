using System.Collections.Generic;

namespace ToDoList
{
    public sealed class Singleton
    {
        private static readonly Singleton _instance = new Singleton();

        static Singleton()
        {

        }

        private Singleton()
        {
            
        }

        public static Singleton Instance => _instance;

        public List<string> OpenFiles { get; set; } = new List<string>();
    }
}
