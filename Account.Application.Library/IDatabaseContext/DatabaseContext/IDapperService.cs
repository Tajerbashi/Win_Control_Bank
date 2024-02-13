using System.Data;

namespace Account.Application.Library.ApplicationContext.DatabaseContext
{
    public interface IDapperService
    {
        IDbConnection Execute();
        DataTable GetDataTable(string query, string paging = "");
    }
}
