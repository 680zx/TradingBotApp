using Microsoft.EntityFrameworkCore;
using TradingBotApp.Models;

namespace TradingBotApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<MarketTool> MarketTools { get; set; }
    }
}
