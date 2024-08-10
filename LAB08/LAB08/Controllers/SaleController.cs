using LAB08.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LAB08.Controllers
{
	public class SaleController : Controller
	{
		private readonly CarDealerContext _context;

		public SaleController(CarDealerContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			return View();
		}
	}
}
