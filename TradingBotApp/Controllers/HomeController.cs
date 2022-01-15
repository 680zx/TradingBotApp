using Microsoft.AspNetCore.Mvc;

namespace TradingBotApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
