using Microsoft.AspNetCore.Mvc;

namespace DapperProjectV2.ViewComponents.DashboardComponents
{
    public class _DashboardWidgetComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
