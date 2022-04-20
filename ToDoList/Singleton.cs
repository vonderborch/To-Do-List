using Octokit;
using Velentr.Miscellaneous;

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

        public Guard SaveGuard = new Guard();

        public GitHubClient Client => new GitHubClient(new ProductHeaderValue(Constants.AppHeaderName));
    }
}