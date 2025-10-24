using System.Diagnostics;
using ltt_231230910_de01.Models;
using Microsoft.AspNetCore.Mvc;

namespace ltt_231230910_de01.Controllers
{
    public class LttHomeController : Controller
    {
        private readonly ILogger<LttHomeController> _logger;

        public LttHomeController(ILogger<LttHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult LttIndex()
        {
            return View();
        }

        public IActionResult LttPrivacy()
        {
            return View();
        }

        public IActionResult LttContact()
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
