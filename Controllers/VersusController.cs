using Microsoft.AspNetCore.Mvc;

namespace top_5.Controllers
{
    public class VersusController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Winner()
        {
            return View();
        }
    }
}
