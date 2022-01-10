using MarketProcessor.MarketConditionQualifiers.Interfaces;

namespace TradingBotApp.Models
{
    public class MarketTool
    {
        public int MarketQualifierId { get; set; }

        public string? Name { get; set; }

        public bool? Enabled { get; set; }

        public IMarketConditionQualifier? MarketConditionQualifier { get; set; }
    }
}
