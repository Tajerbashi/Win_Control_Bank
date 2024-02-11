using Account.Application.Library.BaseModels;
using Account.Application.Library.BaseService;
using Account.Domain.Library.Bases;

namespace Account.Applicatino.Library.Patterns
{
    #region Before
    //public interface IUnitOfWork<out TContext>
    // where TContext : IContextDbApplication, IDisposable, new()
    //{
    //    IGenericRepository<TEntity, TDTO, TView> Repository<TEntity, TDTO, TView>()
    //        where TEntity : BaseEntity, new()
    //        where TDTO : BaseDTO
    //        where TView : BaseView;
    //    //Start the database Transaction
    //    void BeginTransaction();
    //    //Commit the database Transaction
    //    void Commit();
    //    //Rollback the database Transaction
    //    void Rollback();
    //    //DbContext Class SaveChanges method
    //    void Save();
    //    void Dispose();
    //}
    #endregion

    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<TEntity, TDTO, TView> Repository<TEntity, TDTO, TView>()
            where TEntity : BaseEntity, new()
            where TDTO : BaseDTO, new()
            where TView : BaseView, new();
        //Start the database Transaction
        void BeginTransaction();
        //Commit the database Transaction
        void Commit();
        //Rollback the database Transaction
        void Rollback();
        //DbContext Class SaveChanges method
        void Save();
        void Dispose();
    }

}
