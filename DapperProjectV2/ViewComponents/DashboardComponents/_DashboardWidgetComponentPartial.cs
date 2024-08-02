using DapperProjectV2.Services;
using Microsoft.AspNetCore.Mvc;

namespace DapperProjectV2.ViewComponents.DashboardComponents
{
    public class _DashboardWidgetComponentPartial : ViewComponent
    {
        private readonly  IWidgetService _widgetService;

        public _DashboardWidgetComponentPartial(IWidgetService widgetService)
        {
            _widgetService = widgetService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.getCarCount = await _widgetService.GetCarCountAsync();
            ViewBag.GetCarOrderThan2012Count = await _widgetService.GetCarOrderThan2012CountAsync();
            ViewBag.GetCarWithManuelGearCount = await _widgetService.GetCarWithManuelGearCountAsync();
            ViewBag.GetIstanbulCarPlateCount = await _widgetService.GetIstanbulCarPlateCountAsync();
            ViewBag.GetlicensedBefore1998 = await _widgetService.GetlicensedBefore1998Async();
            ViewBag.GetMotorVolumeCount = await _widgetService.GetMotorVolumeCountAsync();
            ViewBag.GetRedCarCount = await _widgetService.GetRedCarCountAsync();
            ViewBag.GetSedanCarCount = await _widgetService.GetSedanCarCountAsync();
            return View();
        }
    }
}
