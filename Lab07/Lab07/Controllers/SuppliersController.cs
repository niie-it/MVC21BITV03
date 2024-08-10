using Lab07.Data;
using Microsoft.AspNetCore.Mvc;

namespace Lab07.Controllers
{
    public class SuppliersController : Controller
    {
        private readonly MvcNiieLabContext _ctx;

        public SuppliersController(MvcNiieLabContext ctx)
        {
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            return View(_ctx.Suppliers.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Supplier model, IFormFile LogoImage)
        {
            if (ModelState.IsValid)
            {
                _ctx.Add(model);
                _ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
