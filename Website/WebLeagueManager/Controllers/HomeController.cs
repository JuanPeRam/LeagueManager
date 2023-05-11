using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebLeagueManager.Models;
using WebLeagueManager.Views.Home;

namespace WebLeagueManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Teams()
        {
            TeamsModel model = new TeamsModel();
            return View(model);
        }

        public IActionResult Team(int id)
        {
            TeamModel model = new TeamModel(id);
            return View(model);
        }

        public IActionResult Rankings()
        {
            RankingsModel model = new RankingsModel();
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}