using Microsoft.Data.SqlClient;
using System.Data;

namespace Infrastructure.Library.ApplicationContext.DapperService
{
    public class DapperServices
    {
        private readonly IDbConnection _connection;
        public DapperServices()
        {
            //_connection = new SqlConnection(@"Data Source=172.20.1.20\\DEV;Initial Catalog=RG_TaskWorkDB; User ID=sa; Password=soft157703ware;");
            _connection = new SqlConnection(@"Data Source=TAJERBASHI;Initial Catalog=Accounting_Db; User ID=sa; Password=123123;TrustServerCertificate=True;");
        }

        public IDbConnection Execute { get { return _connection; } }
    }
}
