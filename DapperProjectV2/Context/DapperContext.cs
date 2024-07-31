using System.Data;
using System.Data.SqlClient;

namespace DapperProjectV2.Context
{
    public class DapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _ConnectionString;
        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _ConnectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public IDbConnection CreateConnection() => new SqlConnection(_ConnectionString);
    }
}
