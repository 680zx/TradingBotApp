using System.ComponentModel.DataAnnotations;

namespace TradingBotApp.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public RamvQualifierTool RamvQualifierTool{ get; set; }
    }
}
