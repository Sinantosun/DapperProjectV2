using Microsoft.AspNetCore.Mvc;

namespace DapperProjectV2.ViewComponents.LayoutComponents
{
    public class _UINavBarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
