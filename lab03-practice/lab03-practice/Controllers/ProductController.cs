using lab03_practice.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab03_practice.Controllers
{
    public class ProductController : Controller
    {
        protected Product product = new Product();
        
        public IActionResult Index()
        {
            var products = product.GetProductList();
            return View(products);
        }

       
    }
}
