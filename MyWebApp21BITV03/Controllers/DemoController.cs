using Microsoft.AspNetCore.Mvc;

namespace MyWebApp21BITV03.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult XoSo()
        {
            //xử lý nghiệp vụ
            var boSo = new List<string>()
            {
                "06", "13", "19", "25", "35", "48"
            };

            return View(boSo);
        }
    }
}
