using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NpoiSample.Controllers
{
    public class UploadController : Controller
    {
        [HttpPost]
        public IActionResult Index(IFormFile formFile)
        {
            return View();
        }
    }
}