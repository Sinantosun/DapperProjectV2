using Dapper;
using DapperProjectV2.Context;
using DapperProjectV2.Dtos.CarDtos;
using DapperProjectV2.Dtos.ChartDto;
using Newtonsoft.Json;
using X.PagedList;
using X.PagedList.Extensions;

namespace DapperProjectV2.Services.CarServices
{
    public class CarService : ICarService
    {
        private readonly DapperContext _context;

        public CarService(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ResultCarDto>> GetCarListAsync()
        {
            var query = "select * from Plates";
            var connection = _context.CreateConnection();
            var result = await connection.QueryAsync<ResultCarDto>(query);
            return result;

        }

        public async Task<List<ResultCarBrandDto>> GetCarOfBrandCountAsync()
        {
            var query = "select brand, COUNT(*) as count from plates group by brand";
            var connection = _context.CreateConnection();
            var result = await connection.QueryAsync<ResultCarBrandDto>(query);
            return result.ToList();
        }

        public async Task<List<ResultCarFuelDto>> GetCarUsingFuelChartAsync()
        {
            var query = "select Brand as Brand, COUNT(*) as Count from plates where Fuel = @Fuel group by Brand";
            var parametres = new DynamicParameters();
            parametres.Add("@Fuel", "Benzin");
            var connection = _context.CreateConnection();
            var result = await connection.QueryAsync<ResultCarFuelDto>(query,parametres);
            return  result.ToList();
        }

        public async Task<List<ResultMotorVolumeDto>> GetMotorVolumeCountAsync()
        {
            var query = "select Brand, COUNT(*) as count from PLATES where MOTORVOLUME != @MOTORVOLUME group by Brand";
            var parametres = new DynamicParameters();
            parametres.Add("@MOTORVOLUME", "1301-1600 cc");
            var connection = _context.CreateConnection();
            var result = await connection.QueryAsync<ResultMotorVolumeDto>(query,parametres);
            return result.ToList();
        }

        public async Task<List<ResultRandomCarDto>> Get10HeigestCarModelAsync()
        {
            var query = "select top 10 * from plates  where YEAR_ = (SELECT MAX(YEAR_) FROM plates);";
            var connection = _context.CreateConnection();
            var result = await connection.QueryAsync<ResultRandomCarDto>(query);
            return result.ToList();
        }

        public async Task<IEnumerable<ResultCarDto>> GetCarFilter(string filter)
        {
            filter = "%" + filter + "%";
            var query = "select * from plates where FUEL like @FUEL or SHIFTTYPE like @SHIFTTYPE OR BRAND like @BRAND or PLATE like @PLATE or YEAR_  like @YEAR_ ";
            var parametres = new DynamicParameters();
            parametres.Add("@FUEL", filter);
            parametres.Add("@SHIFTTYPE", filter);
            parametres.Add("@BRAND", filter);
            parametres.Add("@PLATE", filter);
            parametres.Add("@YEAR_", filter);
            var connection = _context.CreateConnection();
            var result = await connection.QueryAsync<ResultCarDto>(query, parametres);
            return result;
        }
    }
}
