using Microsoft.EntityFrameworkCore;
using TradingBotApp.Models;

namespace TradingBotApp.Data
{
    public class SeedData
    {
        private DataContext dbContext;

        public SeedData(DataContext dbContext) { this.dbContext = dbContext; }

        //public void SeedDatabase(IApplicationBuilder app)
        //{
        //    DataContext context = app.ApplicationServices.CreateScope()
        //        .ServiceProvider.GetRequiredService<DataContext>();

        //    if (context.Database.GetPendingMigrations().Any())
        //    {
        //        context.Database.Migrate();
        //    }

        //    var users = new List<User>()
        //    {
        //        new User { Name = "Test1", Email = "test1@email.io" },
        //        new User { Name = "Test2", Email = "test2@email.io" },
        //        new User { Name = "Test3", Email = "test3@email.io" },
        //        new User { Name = "Test4", Email = "test4@email.io" }
        //    };

        //    //if (!context.Users.Any())
        //    //{
        //    //    context.Users.AddRange(users);
             
        //    //    context.SaveChanges();
        //    //}

        //    if (!context.RamvQualifiers.Any())
        //    {
        //        var ramvs = new List<RamvQualifierTool>();
        //        for (int i = 0; i < users.Count; i++)
        //        {
        //            ramvs.Add(new RamvQualifierTool
        //            {
        //                User = users[i],
        //                MacdMaxDeviation = 0.2,
        //                MaxRecurrentCandleStickPeriod = 6,
        //                MinRecurrentCandleStickPeriod = 3,
        //                Status = true
        //            });
        //        }

        //        context.RamvQualifiers.AddRange(ramvs);

        //        context.SaveChanges();
        //    }
        //}
    }
}
