using Account.Application.Library.IDatabaseContext.DatabaseContext;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Account.Infrastructure.Library.ApplicationContext.GridDataConnection
{
    public class ExecuteDataTableQuery : IExecuteDataTableQuery
    {
        SqlConnection _con;
        public ExecuteDataTableQuery()
        {
            _con = new SqlConnection(@"Data Source=RHG-DATABASE\DEV;Initial Catalog=Accounting_Db; User ID=sa; Password=soft157703ware;TrustServerCertificate=True;");

            //_con = new SqlConnection(@"
            //    Data Source=TAJERBASHI;
            //    Initial Catalog=Accounting_Db; 
            //    User ID=sa; 
            //    Password=123123;
            //    TrustServerCertificate=True;
            //    ");
        }
        public DataTable Execute(string query)
        {
            string cmd = query;

            var sqladapter = new SqlDataAdapter(cmd, _con);
            var commondbuilder = new SqlCommandBuilder(sqladapter);
            var result = new DataSet();
            sqladapter.Fill(result);
            //_con.Close();
            //_con.Dispose();
            return result.Tables[0];
        }

    }
}
