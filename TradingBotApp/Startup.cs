using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;

namespace TradingBotApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddControllersWithViews(MvcOptions =>
            {
                MvcOptions.EnableEndpointRouting = false;
            });
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseStatusCodePages();
            app.UseMvc(routes =>
            {
            });
        }
    }
}
