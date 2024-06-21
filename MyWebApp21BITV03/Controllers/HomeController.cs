using Microsoft.AspNetCore.Mvc;
using MyWebApp21BITV03.Models;
using System.Diagnostics;

namespace MyWebApp21BITV03.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string ActionTest()
        {
            return "Hello World";
        }

        public string Hello(string name = "Tèo")
        {
            return $"Hello {name}";
        }


        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
