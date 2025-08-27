using Microsoft.AspNetCore.Mvc;

namespace day02_controller.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Profile()
        {
            ViewBag.Title = "User Profile";
            ViewBag.Username = "thaole";
            ViewBag.Email = "thao@gmail.com";
            return View();
        }

        public IActionResult Register()
        {
            ViewBag.Title = "User Registration";
            ViewBag.Message = "Please fill in the form to register a new account";
            return View();
        }

        public IActionResult Login()
        {
            return RedirectToAction("Profile");
        }

        public IActionResult Logout()
        {
            ViewBag.Message = "You have successfully logged out";
            return RedirectToAction("List", "Product");
        }
    }
}
