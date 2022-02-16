using TradingBotApp.Data;
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
            services.AddDbContext<DataContext>(optionsBuilder =>
            {
                optionsBuilder.UseSqlServer(Configuration["ConnectionStrings:TradingBotDbConnecton"],
                    options => options.EnableRetryOnFailure());
            });

            services.AddScoped<IMarketToolRepository, MarketToolRepository>();
            services.AddTransient<SeedData>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
            SeedData seedData, IHostApplicationLifetime lifetime)
        {                        
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseStatusCodePages();
            
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllerRoute("default", "Home",
                //    new { Controller = "Home", action = "Index" });

                //endpoints.MapControllerRoute("default", "MarketTools",
                //    new { Controller = "MarketTools", action = "Index" });
                //endpoints.MapControllers();
                endpoints.MapDefaultControllerRoute();
            });

            var cmdLineInit = (Configuration["INITDB"] ?? "false") == "true";
            if (env.IsDevelopment() || cmdLineInit)
            {
                seedData.SeedDatabase(app);
                if (cmdLineInit)
                    lifetime.StopApplication();
            }
        }
    }
}
