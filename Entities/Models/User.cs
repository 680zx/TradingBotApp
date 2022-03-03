using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nickname is required")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "Name length cannot be less than 4")]
        public string? Nickname { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; }

        public RamvQualifierMarketTool? RamvQualifierTool{ get; set; }
    }
}
