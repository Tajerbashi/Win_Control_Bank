using Account.Application.Library.Models.Controls;

namespace Account.Application.Library.BaseService
{
    public interface IBaseQueries
    {
        string GetCount();
        string ShowAll(string paging);
        string Search(string value);
        string ShowFromTo(string from, string to);
        IEnumerable<KeyValue<long>> TitleValue();
    }
}
