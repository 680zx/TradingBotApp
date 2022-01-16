using TradingBotApp.DAL.Repositories.Interfaces;
using TradingBotApp.Models;

namespace TradingBotApp.DAL.Repositories.Implementation
{
    public class TradingBotAppRepository : ITradingBotAppRepository
    {
        private AppDbContext _dbContext;

        public TradingBotAppRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<MarketTool> MarketTools => _dbContext.MarketTools;
    }
}
