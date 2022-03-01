using Entities;
using Microsoft.AspNetCore.Mvc;

namespace TradingBotApp.Controllers
{
    public class UserMarketToolsController : Controller
    {
        private readonly RepositoryContext _context;

        public UserMarketToolsController(RepositoryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //var userId = 0;
            //var tools = _context.Users.Where(i => i.Id == userId).Select(i => new List<MarketTool>
            //{
            //    i.RamvQualifierTool
            //}).FirstOrDefault();

            return View();// (tools ?? new List<MarketTool>());
        }

        public IActionResult Edit(string name)
        {
            if (name == null)
                return NotFound();

            //var marketTool = _marketToolsRepository.GetAll(20).Where(i => i.Name == name)
            //    .First();
            //if (marketTool == null)
            //    return NotFound();

            //if (marketTool.MarketConditionQualifier is RamvQualifier ramvQualifier)
            //    return View("RamvViewEdit", ramvQualifier);

            return View();
        }
    }
}
