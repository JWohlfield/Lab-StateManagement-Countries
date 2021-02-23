using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StateManagement_Countries.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StateManagement_Countries.Controllers
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
            List<Country> countries = new List<Country>
            {
                new Country{Name = "USA", Language = "English", Greeting = "Hello world!", Description = "United States", Colors = new [] {"red" , "white", "blue"} },
                new Country{Name = "MEX", Language = "Spanish", Greeting = "Hola mundo!", Description = "Mexico", Colors = new [] {"red" , "white", "greeen"} }

            };
            return View(countries);
        }

        [HttpPost]
        public IActionResult Index(Country c)
        {
            TempData["Name"] = c.Name;
            TempData["Description"] = c.Description;

            return RedirectToAction("Details", c);

        }

        public IActionResult Details(Country c)
        {
            return View(c);
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
