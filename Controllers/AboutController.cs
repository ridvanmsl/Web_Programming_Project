using Microsoft.AspNetCore.Mvc;

namespace WebAssignment.Controllers
{
    public class AboutController : Controller
    {
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(string name)
        {
            ViewBag.Name = name.ToUpper();
            return View("Show");
        }
    }
}
