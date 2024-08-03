using DapperProjectV2.Services.CarServices;
using Microsoft.AspNetCore.Mvc;

namespace DapperProjectV2.ViewComponents.DashboardComponents
{
    public class _DashboardTableComponentPartial : ViewComponent
    {
        private readonly ICarService _carService;

        public _DashboardTableComponentPartial(ICarService carService)
        {
            _carService = carService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _carService.Get10HeigestCarModelAsync();
            return View(values);
        }
    }
}
