using System.ComponentModel.DataAnnotations;

namespace TradingBotApp.Models
{
    public abstract class MarketTool
    {
        [Key]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Name")]
        public virtual string Name { get; set;  }

        [Display(Name = "Is Enabled")]
        public bool Status { get; set; }
    }
}
