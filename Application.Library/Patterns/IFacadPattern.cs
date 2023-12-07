using Infrastructure.Library.ApplicationContext.GridDataConnection;
using System.Data;

namespace Infrastructure.Library.Patterns
{
    public interface IFacadPattern
    {
        DataTable ExecuteQuery(string query);
    }
    public class FacadPattern : IFacadPattern
    {
        private IBaseQuery _gridQuery;
        protected IBaseQuery GridQuery { get => _gridQuery = _gridQuery ?? new BaseQuery(); }
        public DataTable ExecuteQuery(string query)
        {
            return GridQuery.Execute(query);
        }
    }
}
