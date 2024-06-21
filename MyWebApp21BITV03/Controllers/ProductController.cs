using Microsoft.AspNetCore.Mvc;
using MyWebApp21BITV03.Models;

namespace MyWebApp21BITV03.Controllers
{
    public class ProductController : Controller
    {
        static List<Product> products = new List<Product>()
        {
            new Product{ID = 1, Name="IP15", Price=1300},
            new Product{ID = 2, Name="IP16", Price=1599},
            new Product{ID = 3, Name="SS S24", Price=1369},
        };

        public IActionResult Index()
        {
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            //xử lý
            var existedProduct = products.SingleOrDefault(p => p.ID == product.ID);
            if (existedProduct == null)
            {
                products.Add(product);
                ViewBag.Message = "Thêm mới thành công";
            }
            else
            {
                ViewBag.Message = "Mã sản phẩm đã có. Vui lòng nhập mã khác";
                return View();
            }

            return View("Index", products);
        }

        public IActionResult Delete(int id)
        {
            var existedProduct = products.SingleOrDefault(p => p.ID == id);
            if (existedProduct != null)
            {
                products.Remove(existedProduct);
            }

            return View("Index", products);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var existedProduct = products.SingleOrDefault(p => p.ID == id);
            return View(existedProduct);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            var existedProduct = products.SingleOrDefault(p => p.ID == product.ID);
            if (existedProduct != null)
            {
                existedProduct.Price = product.Price;
                existedProduct.Name = product.Name;
            }
            return RedirectToAction("Index", "Product");
        }
    }
}
