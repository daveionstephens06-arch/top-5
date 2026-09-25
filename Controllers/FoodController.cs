using Microsoft.AspNetCore.Mvc;

namespace top_5.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Number1()
        {
            return View();
        }
    }
}
