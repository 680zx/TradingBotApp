using Microsoft.EntityFrameworkCore;
using TradingBotApp.Models;
using MarketProcessor.MarketConditionQualifiers.Interfaces;

namespace TradingBotApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<MarketTool> MarketTools { get; set; }

        public DbSet<IMarketConditionQualifier> MarketQualifiers { get; set; }
    }
}
