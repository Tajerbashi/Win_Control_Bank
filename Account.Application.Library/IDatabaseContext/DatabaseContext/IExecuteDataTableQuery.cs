using System.Data;

namespace Account.Application.Library.IDatabaseContext.DatabaseContext
{
    public interface IExecuteDataTableQuery
    {
        DataTable Execute(string query);
    }
}
