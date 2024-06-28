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

		public async Task<IActionResult> AsyncDemo()
		{
			var sw = new Stopwatch();
			sw.Start();
			var a =MyClass.FuncAAsync();
			var b = MyClass.FuncBAsync();
			var c = MyClass.FuncCAsync();
			await a; await b; await c;
			sw.Stop();

			return Content($"Chạy sync hết {sw.ElapsedMilliseconds}ms");
		}

		public IActionResult Tet()
		{
			return View();
		}
	}
}
