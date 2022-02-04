using Microsoft.AspNetCore.Mvc;
using TradingBotApp.Data.Repositories.Interfaces;

namespace TradingBotApp.Controllers
{
    public class HomeController : Controller
    {
        private ITradingBotAppRepository _repository;

        public HomeController(ITradingBotAppRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = "Welcome to Trading Bot App";

            return View();
        }
    }
}
