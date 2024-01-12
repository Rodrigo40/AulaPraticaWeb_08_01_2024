using AulaPraticaWeb_08_01_2024.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AulaPraticaWeb_08_01_2024.Controllers
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
            ViewBag.data = $"Bem vindo {DateTime.Now.Year}";
            return View();
        }
        public IActionResult While_Enquanto()
        {
            return View();
        }
        public IActionResult For_Para()
        {
            return View();
        }
        public IActionResult Foreatch_Usnado()
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
