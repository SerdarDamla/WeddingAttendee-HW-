using introDotNetCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace introDotNetCore.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Name1 = "Serdar";
            ViewBag.Name2 = "Elif";
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(WeddingAttendee weddingAttendee)
        {
            ViewBag.Success=false;
            if (ModelState.IsValid)
            {
                if (weddingAttendee.isComeWedding)
                {
                    ViewBag.Success = true;
                }
                
                return View("ResultView");
            }
            
            return View();
        }
    }
}
