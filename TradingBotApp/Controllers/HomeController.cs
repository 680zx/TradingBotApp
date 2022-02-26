using Microsoft.AspNetCore.Mvc;
using TradingBotApp.Data.Repositories.Interfaces;

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
