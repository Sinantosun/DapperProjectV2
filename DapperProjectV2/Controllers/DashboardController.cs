using Dapper;
using DapperProjectV2.Context;
using DapperProjectV2.Dtos.ChartDto;
using DapperProjectV2.Services;
using DapperProjectV2.Services.CarServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DapperProjectV2.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ICarService _carService;

        public DashboardController(ICarService carService)
        {
            _carService = carService;
        }

        public IActionResult Index()
        {
          
            return View();
        }

        public async Task<IActionResult> GetCarUsingFuelChart()
        {
            var result = await _carService.GetCarUsingFuelChartAsync();
            var jsonValues = JsonConvert.SerializeObject(result);

            return Json(jsonValues);
        }

        public async Task<IActionResult> GetCarOfBrandCount()
        {
            var result = await _carService.GetCarOfBrandCountAsync();
            var jsonValues = JsonConvert.SerializeObject(result);
            return Json(jsonValues);
        }
        public async Task<IActionResult> GetMotorVolumeCount()
        {
            var result = await _carService.GetMotorVolumeCountAsync();
            var jsonValues = JsonConvert.SerializeObject(result);
            return Json(jsonValues);
        }
    }
}
