using Microsoft.AspNetCore.Mvc;

namespace DapperProjectV2.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
