﻿using TradingBotApp.Data;
using Microsoft.EntityFrameworkCore;
using TradingBotApp.Data.Repositories.Interfaces;
using TradingBotApp.Data.Repositories.Implementation;

namespace TradingBotApp
{
    public class Startup
    {
        private IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(Configuration["ConnectionStrings:TradingBotDbConnecton"]);
            });
            services.AddScoped<ITradingBotAppRepository, TradingBotAppRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseStatusCodePages();
            
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("pagination", "Home",
                    new { Controller = "Home", action = "Index" });

                endpoints.MapControllerRoute("pagination", "MarketTools",
                    new { Controller = "MarketTools", action = "Index" });

                endpoints.MapDefaultControllerRoute();
            });

            SeedData.EnsurePopulated(app);
        }
    }
}
