using Account.Application.Library.ApplicationContext.DatabaseContext;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace Account.Application.Library.ApplicationContext.DapperService
{
    public sealed class DapperServices : IDapperService
    {
        private readonly IDbConnection _connection;
        public DapperServices()
        {
            _connection = new SqlConnection(@"Data Source=RHG-DATABASE\DEV;Initial Catalog=Accounting_Db; User ID=sa; Password=soft157703ware;TrustServerCertificate=True;");
            //_connection = new SqlConnection(@"Data Source=TAJERBASHI;Initial Catalog=Accounting_Db; User ID=sa; Password=123123;TrustServerCertificate=True;");
        }
        public DataTable GetDataTable(string query, string paging = "")
        {
            throw new NotImplementedException();
        }

        public IDbConnection Execute()
        {
            return _connection;
        }
    }
}
