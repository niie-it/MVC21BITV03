using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyEShop01.Entities;
using MyEShop01.Models;

namespace MyEShop01.Controllers
{
    public class AjaxController : Controller
    {
        private readonly MyEshopContext _ctx;

        public AjaxController(MyEshopContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet]
        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(string keyword)
        {
            var data = _ctx.HangHoas.Where(hh => hh.TenHh.Contains(keyword))
                .Select(hh => new KetQuaTimKiemVM
                {
                    MaHh = hh.Id, TenHh = hh.TenHh,
                    DonGia = hh.DonGia ?? 0,
                    NgaySX = hh.NgaySx,
                    Loai = hh.MaLoaiNavigation.TenLoai
                })
                .ToList();

            return PartialView("TimKiemPartial", data);
        }


        [HttpGet]
        public IActionResult TimKiem()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TimKiem(string? name, double? fromPrice, double? toPrice)
        {
            var dsHangHoa = _ctx.HangHoas.Include(hh => hh.MaLoaiNavigation).AsQueryable();
            if (name != null)
            {
                dsHangHoa = dsHangHoa.Where(hh => hh.TenHh.Contains(name));
            }
            if (fromPrice != null)
            {
                dsHangHoa = dsHangHoa.Where(hh => hh.DonGia.Value >= fromPrice);
            }
            if (toPrice != null)
            {
                dsHangHoa = dsHangHoa.Where(hh => hh.DonGia.Value <= toPrice);
            }
            var data = dsHangHoa.Select(hh => new KetQuaTimKiemVM
            {
                MaHh = hh.Id,
                TenHh = hh.TenHh,
                DonGia = hh.DonGia.Value,
                NgaySX = hh.NgaySx,
                Loai = hh.MaLoaiNavigation.TenLoai
            }).ToList();
            return PartialView("TimKiemPartial", data);
        }

    }
}
