using Microsoft.Data.SqlClient;
using System.Data;

namespace Infrastructure.Library.ApplicationContext.GridDataConnection
{
    public interface IBaseQuery
    {
        DataTable Execute(string query);
    }
    public class BaseQuery : IBaseQuery
    {
        SqlConnection _con;
        public BaseQuery()
        {
            //_con = new SqlConnection(@"Data Source=RHG-DATABASE\DEV;Initial Catalog=Accounting_Db; User ID=sa; Password=soft157703ware;TrustServerCertificate=True;");

            _con = new SqlConnection(@"
                Data Source=TAJERBASHI;
                Initial Catalog=Accounting_Db; 
                User ID=sa; 
                Password=123123;
                TrustServerCertificate=True;
                ");
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
