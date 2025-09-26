using DotNetOpenAuth.OpenId.Extensions.SimpleRegistration;
using lab06_annotation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace lab06_annotation.Controllers
{
    public class StudentController : Controller
    {
        private List<Student> listStudents = new List<Student>();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            ViewBag.AllBranches = new List<SelectListItem>() {
                new SelectListItem(){ Text="IT", Value="1"},
                new SelectListItem(){ Text="BE", Value="2"},
                new SelectListItem(){ Text="CE", Value="3"},
                new SelectListItem(){ Text="EE", Value="4"}
            };
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                s.Id = listStudents.Last().Id + 1;
                if (listStudents.Any())
                {
                    s.Id = listStudents.Last().Id + 1;
                }
                else
                {
                    s.Id = 1; 
                }
                listStudents.Add(s);
                return View("Index", listStudents);
            }
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();

            ViewBag.AllBranches = new List<SelectListItem>() {
                new SelectListItem(){ Text="IT", Value="1"},
                new SelectListItem(){ Text="BE", Value="2"},
                new SelectListItem(){ Text="CE", Value="3"},
                new SelectListItem(){ Text="EE", Value="4"}
            };

            return View();
        }
    }
}
