using Microsoft.AspNetCore.Mvc;

namespace top_5.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("rank/{id:int:range(1,5)}")]
        public IActionResult Number(int id)
        {
            string[] items =
            {
                "Ackee and Saltfirsh",
                "Curry Goat",
                "Chicken and Fries",
                "Rice and Peas",
                "Chicken Soup",
                "Rice and Mackerel"
            };

            //if (id > items.Length || id < 1)
            //{
            //    return NotFound();
            //}

            ViewData["items"] = $"{items[id-1]}";
            return View();
        }
        [HttpGet("about-my-list")]
        public IActionResult About()
        {
            return View();
        }
        [HttpGet("dish/{**anything}")]
        public IActionResult NotInList(string anything)
        {
            ViewData["Asked"] = anything;
            return View();
        }
    }
}
