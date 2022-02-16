using Microsoft.EntityFrameworkCore;
using TradingBotApp.Models;

namespace TradingBotApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<RamvQualifierTool> RamvQualifiers { get; set; }
    }
}
