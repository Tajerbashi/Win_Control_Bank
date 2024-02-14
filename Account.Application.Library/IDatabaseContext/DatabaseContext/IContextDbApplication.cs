using System.Data;

namespace Account.Application.Library.IDatabaseContext.DatabaseContext
{
    public interface IContextDbApplication
    {
        DataTable GetDataTable(string query,string paging);
    }
}
