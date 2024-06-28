using DemoBuoi03.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoBuoi03.Controllers
{
	public class DemoController : Controller
	{
		public IActionResult SyncDemo()
		{
			var sw = new Stopwatch();
			sw.Start();
			MyClass.FuncA();
			MyClass.FuncB();
			MyClass.FuncC();
			sw.Stop();

			return Content($"Chạy sync hết {sw.ElapsedMilliseconds}ms");
		}
	}
}
