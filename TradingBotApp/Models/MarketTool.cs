using System.ComponentModel.DataAnnotations;

namespace TradingBotApp.Models
{
    public class MarketTool
    {
        [Key]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Name")]
        public virtual string Name { get; }

        [Display(Name = "Is Enabled")]
        public bool Enabled { get; set; }

        public User User { get; set; }
    }
}
