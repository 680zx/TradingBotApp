using MarketProcessor.MarketConditionQualifiers.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TradingBotApp.Models
{
    public class MarketTool
    {
        [Key]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Is Enabled")]
        public bool Enabled { get; set; }
        
        public string MarketQualifierSettingsJson { get; set; }

        [NotMapped]
        public IMarketConditionQualifier MarketConditionQualifier { get; set; }
    }
}
