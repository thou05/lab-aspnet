using lab03_practice.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab03_practice.Controllers
{
    public class CategoryController : Controller
    {
        protected Category category = new Category();
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult Category()
        {
            var categories = category.GetCategoryList();
            return PartialView(categories);
        }
    }
}
