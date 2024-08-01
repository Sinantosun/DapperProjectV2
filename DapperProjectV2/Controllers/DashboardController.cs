using Dapper;
using DapperProjectV2.Context;
using DapperProjectV2.Dtos.WidgetDtos;
using DapperProjectV2.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DapperProjectV2.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IWidgetService _widgetService;

        public DashboardController(IWidgetService widgetService)
        {
            _widgetService = widgetService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _widgetService.GetCarCountAsync();

            return View();
        }

        public async Task<IActionResult> GetBrandChart()
        {
            ////brand as Brand, count(brand) as Count from PLATES group by BRAND
            //var query = "select brand as Brand, count(brand) as Count from PLATES group by BRAND";
            //var connection = _context.CreateConnection();
            //var result = await connection.QueryAsync<ResultBrandChartCountDto>(query);
            //var jsonValues = JsonConvert.SerializeObject(result);

            //return Json(jsonValues);
            return Json("");
        }
    }
}
