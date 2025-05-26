using System.Collections.Generic;

namespace GitHubSearchTest.Models
{
    public class GitHubUserContent
    {
        public string login { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public string avatar_url { get; set; }
        public string repos_url { get; set; }
        public List<GitHubRepository> UserRepositories { get; set; } = new List<GitHubRepository>();
    }
}