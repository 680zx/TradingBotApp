using MarketProcessor.MarketConditionQualifiers.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TradingBotApp.Models
{
    public class MarketTool
    {
        [Key]
        public int MarketToolID { get; set; }

        public string? Name { get; set; }

        public bool? Enabled { get; set; }

        public int QualifierID { get; set; }

        [NotMapped]
        public IMarketConditionQualifier? MarketConditionQualifier { get; set; }
    }
}
