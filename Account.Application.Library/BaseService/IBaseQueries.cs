using Account.Application.Library.Models.Controls;
using System.Data;

namespace Account.Application.Library.BaseService
{
    public interface IDapperService
    {
        IDbConnection Execute();
        DataTable GetDataTable(string query,string paging = "");
    }
    public interface IBaseQueries
    {
        string GetCount();
        string ShowAll(string paging);
        string Search(string value);
        string ShowFromTo(string from, string to);
        IEnumerable<KeyValue<long>> TitleValue();
    }
}
