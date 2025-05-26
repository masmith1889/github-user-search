using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GitHubSearchTest.Models;
using GitHubSearchTest;

namespace GitHubSearchTest.Tests
{
    [TestClass]
    public class GitHubServiceTests
    {
        private GitHubService _service;

        [TestInitialize]
        public void Setup()
        {
            _service = new GitHubService();
        }

        [TestMethod]
        public async Task GetUserAsync_ValidUser_ReturnsUserAndRepos()
        {
            var result = await _service.GetUserAsync("masmith1889");
            Assert.IsNotNull(result);
            Assert.AreEqual("masmith1889", result.login.ToLower());
            Assert.IsTrue(result.UserRepositories.Count <= 5);
        }

        [TestMethod]
        public async Task GetUserAsync_InvalidUser_ReturnsNull()
        {
            var result = await _service.GetUserAsync("invaliduser123456789");
            Assert.IsNull(result);
        }
    }
}
