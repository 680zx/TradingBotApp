using Microsoft.AspNetCore.Mvc;

namespace TradingBotApp.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        public string Invoke()
        {
            return "Navigation menu panel: [hello]";
        }
    }
}
