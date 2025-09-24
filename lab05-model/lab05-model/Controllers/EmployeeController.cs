using lab05_model.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab05_model.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            var employees = new List<Employee>
{
                new Employee { id = "E001", name = "Nguyễn Văn An", gender = "Nam", phone = "0905123456", email = "an.nguyen@company.com", salary = "12,500,000", status = "Đang làm" },
                new Employee { id = "E002", name = "Trần Thị Bích", gender = "Nữ", phone = "0916234567", email = "bich.tran@company.com", salary = "11,200,000", status = "Nghỉ phép" },
                new Employee { id = "E003", name = "Lê Văn Cường", gender = "Nam", phone = "0927345678", email = "cuong.le@company.com", salary = "18,000,000", status = "Đang làm" },
                new Employee { id = "E004", name = "Phạm Thị Dung", gender = "Nữ", phone = "0938456789", email = "dung.pham@company.com", salary = "9,800,000", status = "Thử việc" },
                new Employee { id = "E005", name = "Hoàng Minh Đức", gender = "Nam", phone = "0949567890", email = "duc.hoang@company.com", salary = "20,000,000", status = "Đang làm" },
                new Employee { id = "E006", name = "Vũ Thị Hạnh", gender = "Nữ", phone = "0971678901", email = "hanh.vu@company.com", salary = "14,300,000", status = "Nghỉ thai sản" },
                new Employee { id = "E007", name = "Đặng Văn Khánh", gender = "Nam", phone = "0982789012", email = "khanh.dang@company.com", salary = "16,500,000", status = "Đang làm" },
                new Employee { id = "E008", name = "Ngô Thị Lan", gender = "Nữ", phone = "0993890123", email = "lan.ngo@company.com", salary = "13,700,000", status = "Đang làm" }
            };
            return View(employees);
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }

    }
}
