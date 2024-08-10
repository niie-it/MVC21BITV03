using LAB08.Entities;
using LAB08.Models;
using LAB08.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LAB08.Controllers
{
	public class SaleController : Controller
	{
		private readonly CarDealerContext _context;
        private readonly ICarService _carService;

        public SaleController(CarDealerContext context, ICarService carService)
		{
			_context = context;
			_carService = carService;

        }

		#region 3.3 Add Sales
		[HttpGet]
		public IActionResult Create()
		{
			ViewBag.Customers = new SelectList(_context.Customers.ToList(), "Id", "Name");
			ViewBag.Cars = new SelectList(_carService.GetCars(), "Id", "Name");
			return View();
		}
		#endregion


		#region 1.3.1.1 Query 1 – Ordered Customers
		[HttpGet("/customers/all/ascending")]
		public IActionResult KhachHangTangDan()
		{
			var data = _context.Customers
				.OrderBy(c => c.BirthDate)
				.ThenBy(c => !c.IsYoungDriver)
				.Select(c => new
				{
					c.Name,
					c.BirthDate,
					c.IsYoungDriver
				}).ToList();
			return Json(data);
		}

		[HttpGet("/customers/all/descending")]
		public IActionResult KhachHangGiamDan()
		{
			var data = _context.Customers
				.OrderByDescending(c => c.BirthDate)
				.ThenBy(c => !c.IsYoungDriver)
				.Select(c => new
				{
					c.Name,
					c.BirthDate,
					c.IsYoungDriver
				}).ToList();
			return Json(data);
		}
		#endregion


		//1.3.1.2 Get car from make
		[HttpGet("/cars/{make}")]
		public IActionResult GetCarByMake(string? make)
		{
			var data = _context.Cars.AsQueryable();
			if (make != null)
			{
				data = data.Where(c => c.Make == make);
			}
			var result = data.OrderBy(c => c.Model).ThenByDescending(c => c.TravelledDistance).ToList();
			return Json(result);
		}

		public IActionResult Information()
		{
			var data = _context.Sales
				.Include(s => s.Customer)
				.Include(s => s.Car)
				.Select(s => new KhachHangMuaXeVM
				{
					MaKh = s.CustomerId ?? 0,
					HoTen = s.Customer.Name,
					NgaySinh = s.Customer.BirthDate,
					NhanHieu = s.Car.Make,
					Model = s.Car.Model
				}).ToList();
			return View(data);
		}

		public IActionResult ThongKeTheoKhachHang()
		{
			var data = _context.Customers.Select(c => new
			{
				MaKH = c.Id,
				HoTen = c.Name,
				SoLuongXe = c.Sales.Count
			});
			return Json(data);
		}

		public IActionResult Index()
		{
			return View();
		}
	}
}
