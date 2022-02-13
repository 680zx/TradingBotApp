using Microsoft.EntityFrameworkCore;
using TradingBotApp.Models;

namespace TradingBotApp.Data
{
    public class SeedData
    {
        private DataContext dbContext;

        public SeedData(DataContext dbContext) { this.dbContext = dbContext; }

        public void SeedDatabase(IApplicationBuilder app)
        {
            DataContext context = app.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<DataContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.MarketTools.Any())
            {
                context.MarketTools.AddRange(
                    new MarketTool { Name = "RAMV", Enabled = true },
                    new MarketTool { Name = "PriceAlarm", Enabled = true },
                    new MarketTool { Name = "BullMarket", Enabled = true },
                    new MarketTool { Name = "BearMarket", Enabled = false }
                 );

                //context.MarketQualifiers.AddRange

                context.SaveChanges();
            }
        }
    }
}
