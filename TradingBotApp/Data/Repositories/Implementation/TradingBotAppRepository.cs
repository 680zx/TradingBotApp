using TradingBotApp.Data.Repositories.Interfaces;
using TradingBotApp.Models;

namespace TradingBotApp.Data.Repositories.Implementation
{
    public class TradingBotAppRepository : ITradingBotAppRepository
    {
        private DataContext _dbContext;

        public TradingBotAppRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<MarketTool> MarketTools => _dbContext.MarketTools;
    }
}
