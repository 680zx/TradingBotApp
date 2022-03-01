using Entities;
using Microsoft.EntityFrameworkCore;

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
            services.AddDbContext<RepositoryContext>(optionsBuilder =>
            {
                optionsBuilder.UseSqlServer(Configuration["ConnectionStrings:TradingBotDbConnecton"],
                    options => options.EnableRetryOnFailure());
            });
        }

        public void Configure(IApplicationBuilder app)
        {                        
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseStatusCodePages();
            
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
