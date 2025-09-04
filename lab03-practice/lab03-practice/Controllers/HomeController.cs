using System.Diagnostics;
using lab03_practice.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab03_practice.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        protected Product product = new Product();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var products = product.GetProductList();
            return View(products);
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
