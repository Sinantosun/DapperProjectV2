using Dapper;
using DapperProjectV2.Context;
using DapperProjectV2.Dtos;
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

        public async Task<IActionResult> GetBrandChart()
        {
            //brand as Brand, count(brand) as Count from PLATES group by BRAND
            var query = "select brand as Brand, count(brand) as Count from PLATES group by BRAND";
            var connection = _context.CreateConnection();
            var result = await connection.QueryAsync<ResultBrandCountDto>(query);
            var jsonValues = JsonConvert.SerializeObject(result);

            return Json(jsonValues);
        }
    }
}
