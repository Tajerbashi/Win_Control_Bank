using Account.Application.Library.BaseModels;
using Account.Application.Library.Extentions;
using Account.Domain.Library.Bases;
using System.Data;

namespace Account.Application.Library.BaseService
{
    public interface IGenericRepository<TEntity, TDTO, TView>
        where TEntity : BaseEntity, new()
        where TDTO : BaseDTO, new()
        where TView : BaseView, new()
    {
        IEnumerable<TDTO> GetAll();
        TDTO GetById(object id);
        long Insert(TDTO obj);
        long AddOrUpdate(TDTO obj);
        void Update(TDTO obj);
        void Delete(object id);
        void Delete(Guid guid);
        void DisActive(Guid guid);
        void Active(Guid guid);
        object Save();
        DataTable ExecuteQuery(string query);
        Paging Paging { get; }
        
    }
}
