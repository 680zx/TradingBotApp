namespace TradingBotApp.Models
{
    public class RamvQualifierTool : MarketTool
    {
        public override string Name { get; set; } = "RAMV qualifier";

        public override int ToolTypeId { get => 0; }

        public double MacdMaxDeviation { get; set; }

        public int MinRecurrentCandleStickPeriod { get; set; }

        public int MaxRecurrentCandleStickPeriod { get; set; }
    }
}
