using Microsoft.AspNetCore.Mvc;

namespace DapperProjectV2.ViewComponents.LayoutComponents
{
    public class _UIHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
