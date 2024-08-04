using Dapper;
using DapperProjectV2.Context;
using DapperProjectV2.Dtos.CarDtos;
using DapperProjectV2.Services.CarServices;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;
using X.PagedList.Extensions;


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

        async Task<IPagedList> GetFilter(int pageNumber = 1, string filter = "")
        {
            var result = await _carService.GetCarFilter(filter);
            var pagedList = result.ToPagedList(pageNumber, 10);
            TempData["FilterCount"] = result.Count();
            return pagedList;
        }



        public async Task<IActionResult> Index(int pageNumber = 1, string filter = "")
        {
            if (!string.IsNullOrEmpty(filter))
            {
                TempData["filter"] = filter;
                var pagedList = await GetFilter(pageNumber, filter);
                return View("Index", pagedList);
            }
            else
            {
                var values = await _carService.GetCarListAsync();
                var pagedList = values.ToPagedList(pageNumber, 10);
                return View(pagedList);
            }


        }

        public async Task<IActionResult> CarFilter(string filter)
        {
            TempData["filter"] = filter;
            var pagedList = await GetFilter(1,filter);
            return View("Index", pagedList);
        }
    }
}
