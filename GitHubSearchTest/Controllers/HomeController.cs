using System.Threading.Tasks;
using System.Web.Mvc;
using GitHubSearchTest.Models;

public class HomeController : Controller
{
    private GitHubService _service = new GitHubService();

    [HttpGet]
    public ActionResult Index() => View();

    [HttpPost]
    public async Task<ActionResult> Index(string username)
    {
        if (string.IsNullOrWhiteSpace(username))
        {
            ViewBag.Error = "Username is required.";
            return View();
        }

        var user = await _service.GetUserAsync(username.Trim());

        if (user == null)
        {
            ViewBag.Error = "User not found.";
            return View();
        }

        return View("Result", user);
    }
}
