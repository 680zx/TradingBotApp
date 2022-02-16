using Microsoft.AspNetCore.Mvc;
using TradingBotApp.Data.Repositories.Interfaces;

namespace TradingBotApp.Controllers
{
    public class HomeController : Controller
    {
        private IMarketToolRepository _repository;

        public HomeController(IMarketToolRepository repository)
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
