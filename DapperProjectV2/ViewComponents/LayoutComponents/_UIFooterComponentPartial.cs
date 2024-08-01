using Microsoft.AspNetCore.Mvc;

namespace DapperProjectV2.ViewComponents.LayoutComponents
{
    public class _UIFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
