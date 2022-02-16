using Microsoft.AspNetCore.Mvc;
using TradingBotApp.Data.Repositories.Interfaces;
using MarketProcessor.MarketConditionQualifiers.Implementation;

namespace TradingBotApp.Controllers
{
    public class MarketToolsController : Controller
    {
        private IMarketToolRepository _marketToolsRepository;

        public MarketToolsController(IMarketToolRepository repository)
        {
            _marketToolsRepository = repository;
        }

        public IActionResult Index()
        {
            return View(_marketToolsRepository.GetAll(20));
        }

        public IActionResult Edit(string name)
        {
            if (name == null)
                return NotFound();

            var marketTool = _marketToolsRepository.GetAll(20).Where(i => i.Name == name)
                .First();
            if (marketTool == null)
                return NotFound();

            //if (marketTool.MarketConditionQualifier is RamvQualifier ramvQualifier)
            //    return View("RamvViewEdit", ramvQualifier);

            return View(marketTool);
        }
    }
}
