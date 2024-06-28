using Microsoft.AspNetCore.Mvc;

namespace DemoBuoi03.Controllers
{
    public class FileUploadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UploadFile(IFormFile myfile)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", myfile.FileName);
            using(var newfile = new FileStream(filePath, FileMode.CreateNew))
            {
                myfile.CopyTo(newfile);
            }

            return RedirectToAction("Index");
        }
    }
}
