using Microsoft.EntityFrameworkCore;
//using TradingBotApp.Data.Configuration;
using TradingBotApp.Models;

namespace TradingBotApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<RamvQualifierTool> RamvQualifierTool { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfiguration(new MarketToolConfiguration());
        //}
    }
}
