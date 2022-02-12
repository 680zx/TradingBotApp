using TradingBotApp.Models;
using MarketProcessor.MarketConditionQualifiers.Interfaces;

namespace TradingBotApp.Data.Repositories.Interfaces
{
    public interface ITradingBotAppRepository
    {
        IQueryable<MarketTool> MarketTools { get; }

        IQueryable<IMarketConditionQualifier> MarketQualifiers { get; }
    }
}
