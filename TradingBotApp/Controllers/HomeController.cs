using Microsoft.AspNetCore.Mvc;

namespace TradingBotApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Welcome to Trading Bot App";

            return View();
        }
    }
}
