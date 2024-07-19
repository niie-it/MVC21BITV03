using DemoValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoValidation.Controllers
{
    public class EmployeeController : Controller
    {
        public string CheckExistedEmployeeEmail(string Email)
        {
            var emailsInDb = new List<string> { "admin@gmail.com", "hyhien@gmail.com"};
            return emailsInDb.Contains(Email) ? "false" : "true";
        }

		public IActionResult JoinWithUs()
        {
            return View();
        }

        public IActionResult CheckExistedEmployee(string EmployeeNo)
        {
            var dsNhanVien = new List<string> { "aaaaaa", "bbbbbb", "cccccc"};
            if (dsNhanVien.Contains(EmployeeNo)) return Json($"{EmployeeNo} đã có.");
            return Json(true);
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Employee emp)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("loi", "Còn lỗi k");
            }
            return View();
        }
    }
}
