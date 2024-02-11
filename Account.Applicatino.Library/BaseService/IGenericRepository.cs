using Account.Domain.Library.Bases;

namespace Account.Application.Library.BaseService
{
    public interface IGenericRepository<TEntity, TDTO, TView>
        where TEntity : BaseEntity, new()
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(object id);
        long Insert(TEntity obj);
        long AddOrUpdate(TEntity obj);
        void Update(TEntity obj);
        void Delete(object id);
        void Delete(Guid guid);
        void DisActive(Guid guid);
        void Active(Guid guid);
        object Save();
    }
}
