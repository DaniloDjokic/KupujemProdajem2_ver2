using KupujemProdajem2_ver2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KupujemProdajem2_ver2.Controllers
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
            var products = new List<Product>();

            products.Add(new Product
            {
                Id = 1,
                Name = "Daska 2x2",
                Price = 100,
            });
            products.Add(new Product
            {
                Id = 2,
                Name = "Slusalice Sony XM4",
                Price = 200,
            });
            products.Add(new Product
            {
                Id = 3,
                Name = "LG 4k OLED",
                Price = 300,
            });

            return View(new User() { Id = 1, Name = "Danilo"});
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
