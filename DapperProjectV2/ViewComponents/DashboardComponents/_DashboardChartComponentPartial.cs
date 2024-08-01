using Microsoft.AspNetCore.Mvc;

namespace DapperProjectV2.ViewComponents.DashboardComponents
{
    public class _DashboardChartComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
