using Octokit;

using Velentr.Collections.Helpers;

namespace ToDoList
{
    public sealed class Singleton
    {
        public Guard SaveGuard = new Guard();

        static Singleton() { }

        private Singleton() { }

        public static Singleton Instance { get; } = new Singleton();

        public GitHubClient Client => new GitHubClient(new ProductHeaderValue(Constants.AppHeaderName));
    }
}
