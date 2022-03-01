using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public abstract class MarketTool
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Name")]
        public virtual string? Name { get; }

        [Display(Name = "Is Enabled")]
        public bool Status { get; set; }

        public virtual int ToolTypeId { get; }
    }
}
