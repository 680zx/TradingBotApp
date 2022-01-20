using Microsoft.AspNetCore.Mvc;
using TradingBotApp.DAL.Repositories.Interfaces;

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
            return View(_repository.MarketTools);
        }
    }
}
