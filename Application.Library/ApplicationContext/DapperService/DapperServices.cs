using Microsoft.Data.SqlClient;
using System.Data;

namespace Infrastructure.Library.ApplicationContext.DapperService
{
    public class DapperServices
    {
        private readonly IDbConnection _connection;
        public DapperServices()
        {
            _connection = new SqlConnection("Data Source=TAJERBASHI;Initial Catalog=Accounting_Db; User ID=sa; Password=123123;TrustServerCertificate=True;");
        }

        public IDbConnection Execute { get { return _connection; } }
    }
}
