using DemoValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoValidation.Controllers
{
	public class DemoController : Controller
	{
		public IActionResult Enroll()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Enroll(Student model)
		{
			if (!ModelState.IsValid)
			{
				ModelState.AddModelError("loi", "Còn lỗi");
			}
			return View();
		}
	}
}
