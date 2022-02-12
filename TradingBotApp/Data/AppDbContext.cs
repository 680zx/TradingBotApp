using Microsoft.EntityFrameworkCore;
using TradingBotApp.Models;

namespace TradingBotApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<MarketTool> MarketTools { get; set; }

        public DbSet<MarketQualifier> MarketQualifiers { get; set; }
    }
}
