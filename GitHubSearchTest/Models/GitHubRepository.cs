using System.Collections.Generic;

namespace GitHubSearchTest.Models
{
    public class GitHubRepository
    {
        public string name { get; set; }
        public string html_url { get; set; }
        public string description { get; set; }
        public int stargazers_count { get; set; }
    }
}
