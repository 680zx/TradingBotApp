using TradingBotApp.Models;

namespace TradingBotApp.DAL.Repositories.Interfaces
{
    public interface ITradingBotAppRepository
    {
        IQueryable<MarketTool> MarketTools { get; }
    }
}
