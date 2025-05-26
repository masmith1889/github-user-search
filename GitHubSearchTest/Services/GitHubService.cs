using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using GitHubSearchTest.Models;

public class GitHubService
{
    private readonly HttpClient _client;

    public GitHubService()
    {
        _client = new HttpClient();
        _client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("App", "1.0"));
    }

    public async Task<GitHubUserContent> GetUserAsync(string username)
    {
        var userResponse = await _client.GetAsync($"https://api.github.com/users/{username}");
        if (userResponse.StatusCode == HttpStatusCode.NotFound)
            return null;

        var userJson = await userResponse.Content.ReadAsStringAsync();
        var serializer = new JavaScriptSerializer();
        var user = serializer.Deserialize<GitHubUserContent>(userJson);

        var reposResponse = await _client.GetAsync(user.repos_url);
        var reposJson = await reposResponse.Content.ReadAsStringAsync();
        var repos = serializer.Deserialize<List<GitHubRepository>>(reposJson);

        user.UserRepositories = repos.OrderByDescending(r => r.stargazers_count).Take(5).ToList();
        return user;
    }
}
