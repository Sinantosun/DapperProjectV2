using Dapper;
using DapperProjectV2.Context;
using DapperProjectV2.Dtos.CarDtos;
using DapperProjectV2.Services.CarServices;
using Microsoft.AspNetCore.Mvc;

namespace DapperProjectV2.Controllers
{
    public class DefaultController : Controller
    {
     
         private readonly ICarService _carService;
        private readonly DapperContext _dapperContext;
        public DefaultController(ICarService carService, DapperContext dapperContext)
        {
            _carService = carService;
            _dapperContext = dapperContext;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _carService.GetCarListAsync();
            return View(values);
        }

        public async Task<IActionResult> CarFilter(string filter)
        {
            filter = filter + "%";
            var query = "select * from plates where FUEL like @p1";
            var parametres = new DynamicParameters();
            parametres.Add("@p1", filter);
            var connection = _dapperContext.CreateConnection();
            var result = await connection.QueryAsync<ResultCarDto>(query,parametres);
            return View("Index", result.ToList());
        }
    }
}
