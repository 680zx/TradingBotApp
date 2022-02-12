using Microsoft.EntityFrameworkCore;
using TradingBotApp.Models;

namespace TradingBotApp.Data
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<AppDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.MarketTools.Any())
            {
                context.MarketTools.AddRange(
                    new MarketTool { Name = "RAMV", Enabled = true, MarketConditionQualifierID = 1 },
                    new MarketTool { Name = "PriceAlarm", Enabled = true, MarketConditionQualifierID = 2 },
                    new MarketTool { Name = "BullMarket", Enabled = true, MarketConditionQualifierID = 3 },
                    new MarketTool { Name = "BearMarket", Enabled = false, MarketConditionQualifierID = 4 }
                 );

                //context.MarketQualifiers.AddRange

                context.SaveChanges();
            }
        }
    }
}
