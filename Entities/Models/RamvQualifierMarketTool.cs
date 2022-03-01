using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Utilities.Attributes;

namespace Entities.Models
{
    public class RamvQualifierMarketTool : MarketTool
    {
        [ReadOnly(true)]
        public override string Name => "RAMV Qualifier";

        [ReadOnly(true)]
        public override int ToolTypeId => 0;

        [Required(ErrorMessage = "MacdMaxDeviation is required")]
        [DoubleValidator(minValue: -1, maxValue: 1)]
        public double MacdMaxDeviation { get; set; }

        [Required(ErrorMessage = "MinRecurrentCandleStickPeriod is required")]
        public int MinRecurrentCandleStickPeriod { get; set; }

        [Required(ErrorMessage = "MaxRecurrentCandleStickPeriod is required")]
        public int MaxRecurrentCandleStickPeriod { get; set; }
    }
}
