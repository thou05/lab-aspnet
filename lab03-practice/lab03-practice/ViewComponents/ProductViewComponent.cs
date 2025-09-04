using lab03_practice.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab03_practice.ViewComponents
{
    public class ProductViewComponent : ViewComponent
    {
        protected Product product = new Product();

        public IViewComponentResult Invoke()
        {
            var products = product.GetProductList();
            return View(products);
        }
    }
}
