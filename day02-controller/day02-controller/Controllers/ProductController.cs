using Microsoft.AspNetCore.Mvc;

namespace day02_controller.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            ViewBag.Title = "Product List";
            ViewBag.Products = new List<string> { "Product A", "Product B", "Product C" };
            return View();
        }

        public IActionResult Details(int id)
        {
            ViewBag.Title = "Product Details";
            ViewBag.ProductName = "Laptop Dell XPS 13";
            ViewBag.Price = 30000000;
            
            return View();
        }
    }
}
