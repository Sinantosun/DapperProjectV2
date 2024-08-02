using Dapper;
using DapperProjectV2.Context;
using DapperProjectV2.Dtos.ChartDto;
using DapperProjectV2.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DapperProjectV2.Controllers
{
    public class DashboardController : Controller
    {
       private readonly DapperContext _context;

        public DashboardController(DapperContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
          
            return View();
        }

        public async Task<IActionResult> GetCarUsingFuelChart()
        {
            //brand as Brand, count(brand) as Count from PLATES group by BRAND
            var query = "select Brand as Brand, COUNT(*) as Count from plates where Fuel = 'Benzin' group by Brand";
            var connection = _context.CreateConnection();
            var result = await connection.QueryAsync<ResultCarFuelDto>(query);
            var jsonValues = JsonConvert.SerializeObject(result);

            return Json(jsonValues);
        }

        public async Task<IActionResult> GetCarOfBrandCount()
        {
            //brand as Brand, count(brand) as Count from PLATES group by BRAND
            var query = "select brand, COUNT(*) as count from plates group by brand";
            var connection = _context.CreateConnection();
            var result = await connection.QueryAsync<ResultCarBrandDto>(query);
            var jsonValues = JsonConvert.SerializeObject(result);
            return Json(jsonValues);
        }
    }
}
