using Microsoft.AspNetCore.Mvc;
using TradingBotApp.Data.Repositories.Interfaces;

namespace TradingBotApp.Controllers
{
    public class MarketToolsController : Controller
    {
        private ITradingBotAppRepository _repository;

        public MarketToolsController(ITradingBotAppRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View(_repository.MarketTools);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var marketTool = _repository.MarketTools.Where(i => i.ID == id.Value)
                .First();
            if (marketTool == null)
                return NotFound();

            return View(marketTool);
        }
    }
}
