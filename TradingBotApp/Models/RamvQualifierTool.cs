namespace TradingBotApp.Models
{
    public class RamvQualifierTool : MarketTool
    {
        public override string Name => "RAMV qualifier";

        public double MacdMaxDeviation { get; set; }

        public int MinRecurrentCandleStickPeriod { get; set; }

        public int MaxRecurrentCandleStickPeriod { get; set; }

        public User User { get; set; }
    }
}
