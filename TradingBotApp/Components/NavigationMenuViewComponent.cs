using Microsoft.AspNetCore.Mvc;

namespace TradingBotApp.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
