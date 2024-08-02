using Dapper;
using DapperProjectV2.Context;

namespace DapperProjectV2.Services
{
    public class WidgetService : IWidgetService
    {
        private readonly DapperContext _context;

        public WidgetService(DapperContext context)
        {
            _context = context;
        }

        public async Task<int> GetCarCountAsync()
        {
            var query = "select COUNT(*) from plates";
            var connection = _context.CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query);
            return result;
        }
      
        public async Task<int> GetCarOrderThan2012CountAsync()
        {
            var query = "select COUNT(*) from plates where YEAR_>= @YEAR_";
            var parametres = new DynamicParameters();
            parametres.Add("@YEAR_", 2012);
            var connection = _context.CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query,parametres);
            return result;
        }

        public async Task<int> GetCarWithManuelGearCountAsync()
        {
            var query = "select COUNT(*) from plates where SHIFTTYPE = @SHIFTTYPE";
            var parametres = new DynamicParameters();
            parametres.Add("@SHIFTTYPE", "Düz Vites");
            var connection = _context.CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query,parametres);
            return result;
        }

        public async Task<int> GetIstanbulCarPlateCountAsync()
        {
            var query = "select COUNT(*) from plates where CITYNR = @CITYNR";
            var parametres = new DynamicParameters();
            parametres.Add("@CITYNR", "34");
            var connection = _context.CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query, parametres);
            return result;
        }
     
        public async Task<int> GetlicensedBefore1998Async()
        {
            var query = "select COUNT(*) from PLATES where LICENCEDATE > @LICENCEDATE";
            var parametres = new DynamicParameters();
            parametres.Add("@LICENCEDATE", "01.01.2018");
            var connection = _context.CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query, parametres);
            return result;
        }

        public async Task<int> GetMotorVolumeCountAsync()
        {
            var query = "select COUNT(*) from PLATES where MOTORVOLUME > @MOTORVOLUME";
            var parametres = new DynamicParameters();
            parametres.Add("@MOTORVOLUME", "1301-1600 cc");
            var connection = _context.CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query, parametres);
            return result;
        }

        public async Task<int> GetRedCarCountAsync()
        {
            var query = "select COUNT(*) from PLATES where COLOR = @COLOR";
            var parametres = new DynamicParameters();
            parametres.Add("@COLOR", "kırmızı");
            var connection = _context.CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query, parametres);
            return result;
        }
    
        public async Task<int> GetSedanCarCountAsync()
        {
            var query = "select COUNT(*) from PLATES where CASETYPE > @CASETYPE";
            var parametres = new DynamicParameters();
            parametres.Add("@CASETYPE", "sedan");
            var connection = _context.CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query, parametres);
            return result;
        }
    }
}
