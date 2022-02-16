using TradingBotApp.Models;

namespace TradingBotApp.Data.Repositories.Interfaces
{
    public interface IMarketToolRepository
    {
        public List<MarketTool> GetAll(int userId);

        public IQueryable<RamvQualifierTool> RamvQualifiers { get; }
    }
}
