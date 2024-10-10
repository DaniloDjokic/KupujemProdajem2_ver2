using Microsoft.AspNetCore.Mvc;

namespace KupujemProdajem2_ver2.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewProducts()
        {
            return View();
        }
    }
}
