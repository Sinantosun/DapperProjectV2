using Microsoft.AspNetCore.Mvc;

namespace DapperProjectV2.ViewComponents.LayoutComponents
{
    public class _UILayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();

        }
    }
}
