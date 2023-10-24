using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TextMatch.Models;

namespace TextMatch.Controllers
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
            var model = new TextMatchViewModel
            {
                Text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we’ll all have tea"
            };

            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}