using Account.Application.Library.Repositories.BUS;
using Account.Application.Library.Repositories.CNT;

namespace Account.Application.Library.Patterns
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
        /// <summary>
        /// Start the database Transaction
        /// </summary>
        void BeginTransaction();
        /// <summary>
        /// Commit the database Transaction
        /// </summary>
        void Commit();
        /// <summary>
        /// Rollback the database Transaction
        /// </summary>
        void Rollback();
        /// <summary>
        /// DbContext Class SaveChanges method
        /// </summary>
        /// <returns>int</returns>
        int Save();


        #region BUS
        ICustomerRepository CustomerRepository { get; }
        IBankRepository BankRepository { get; }
        IBlanceRepository BlanceRepository { get; }
        ICartRepository CartRepository { get; }
        ISettlemantRepository SettlemantRepository { get; }
        #endregion


        #region CNT
        IConstVariableRepository ConstVariableRepository { get; }
        #endregion


        #region LOG
        #endregion


        #region RPT
        #endregion

        #region SEC
        #endregion

        #region WEB
        #endregion

    }

}
