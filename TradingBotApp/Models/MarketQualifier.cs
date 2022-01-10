using MarketProcessor.MarketConditionQualifiers.Interfaces;

namespace TradingBotApp.Models
{
    public class MarketQualifier
    {
        public string? Name { get; set; }

        public bool? Enabled { get; set; }

        public IMarketConditionQualifier? MarketConditionQualifier { get; set; }
    }
}
