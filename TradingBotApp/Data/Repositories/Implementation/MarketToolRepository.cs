using TradingBotApp.Data.Repositories.Interfaces;
using TradingBotApp.Models;

namespace TradingBotApp.Data.Repositories.Implementation
{
    public class MarketToolRepository : IMarketToolRepository
    {
        private DataContext _dbContext;

        public MarketToolRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<RamvQualifierTool> RamvQualifiers  => _dbContext.RamvQualifiers;

        public List<MarketTool> GetAll(int userId)
        {
            var r = RamvQualifiers.Where(i => i.User.Id == userId).FirstOrDefault();
            var tools = new List<MarketTool>();
            tools.Add(r);

            return tools;
        }
    }
}
