using TradingBotApp.Models;

namespace TradingBotApp.Data.Repositories.Interfaces
{
    public interface ITradingBotAppRepository
    {
        IQueryable<MarketTool> MarketTools { get; }
    }
}
