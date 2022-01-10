using TradingBotApp.Models;

namespace TradingBotApp.DAL.Interfaces
{
    public interface IMarketToolRepository
    {
        IQueryable<MarketTool> MarketTools { get; }
    }
}
