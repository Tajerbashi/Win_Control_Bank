using Account.Infrastructure.Library.ApplicationContext.DapperService;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.Extentions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Account.Infrastructure.Library.Patterns
{
    public interface IUnitOfWork<out TContext> 
        where TContext : DbContext, IDisposable, new()
    {
        //The following Property is going to hold the context object
        TContext Context { get; }
        //Start the database Transaction
        void BeginTransaction();
        //Commit the database Transaction
        void Commit();
        //Rollback the database Transaction
        void Rollback();
        //DbContext Class SaveChanges method
        void Save();
        void Dispose();

        #region Config
        DapperServices Dapper { get; }

        #endregion



    }
    public class UnitOfWork<TContext> : IUnitOfWork<TContext>
        where TContext : ContextDbApplication, new()
    {
        private bool _disposed;
        private IDbContextTransaction  _objTran;
        public TContext Context { get; }
        private DapperServices _Dapper;
        public DapperServices Dapper { get => _Dapper ?? new DapperServices(); }
        public UnitOfWork()
        {
            Context = new TContext();
            _Dapper = new DapperServices();
        }
        public void BeginTransaction()
        {
            //Context.Database.BeginTransaction();
            _objTran = Context.Database.BeginTransaction();
        }

        public void Commit()
        {
            //Context.Database.CommitTransaction();
            _objTran.Commit();
        }

        public void Dispose()
        {
            _objTran.Dispose();
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Rollback()
        {
            //Context.Database.RollbackTransaction();
            _objTran.Rollback();
            Dispose();
        }

        public void Save()
        {
            Context.SaveChanges();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
                if (disposing)
                    Context.Dispose();
            _disposed = true;
        }
    }
}
