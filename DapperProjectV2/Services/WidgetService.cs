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
        //DYNMAİC PARAAMETES KULLANILACAK
        public async Task<int> GetCarCountAsync()
        {
            var query = "select COUNT(*) from plates";
            var connection = _context.CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query);
            return result;
        }
        //DYNMAİC PARAAMETES KULLANILACAK
        public async Task<int> GetCarOrderThan2012CountAsync()
        {
            var query = "select COUNT(*) from plates where YEAR_>= 2012";
            var connection = _context.CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query);
            return result;
        }
        //DYNMAİC PARAAMETES KULLANILACAK
        public async Task<int> GetCarWithManuelGearCountAsync()
        {
            var query = "select COUNT(*) from plates where SHIFTTYPE ='Düz Vites'";
            var connection = _context.CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query);
            return result;
        }
        //DYNMAİC PARAAMETES KULLANILACAK
        public async Task<int> GetIstanbulCarPlateCount()
        {
            var query = "select COUNT(*) from plates where CITYNR = 35";
            var connection = _context.CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query);
            return result;
        }
        //DYNMAİC PARAAMETES KULLANILACAK
        public async Task<int> GetlicensedBefore1998()
        {
            var query = "select COUNT(*) from PLATES where LICENCEDATE > '01.01.2018'";
            var connection = _context.CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query);
            return result;
        }
        //DYNMAİC PARAAMETES KULLANILACAK
        public async Task<int> GetMotorVolumeCount()
        {
            var query = "select COUNT(*) from PLATES where MOTORVOLUME > '1301-1600 cc'";
            var connection = _context.CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query);
            return result;
        }
        //DYNMAİC PARAAMETES KULLANILACAK
        public async Task<int> GetRedCarCountAsync()
        {
            var query = "select COUNT(*) from PLATES where COLOR > 'red'";
            var connection = _context.CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query);
            return result;
        }
        //DYNMAİC PARAAMETES KULLANILACAK
        public async Task<int> GetSedanCarCountAsync()
        {
            var query = "select COUNT(*) from PLATES where CASETYPE > 'sedan'";
            var connection = _context.CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query);
            return result;
        }
    }
}
