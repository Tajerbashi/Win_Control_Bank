using Account.Application.Library.Patterns;
using Account.Application.Library.ApplicationContext.DapperService;
using Account.Application.Library.ApplicationContext.DatabaseContext;
using Account.Application.Library.BaseModels;
using Account.Application.Library.BaseService;
using Account.Domain.Library.Bases;
using Account.Infrastructure.Library.BaseService;
using Microsoft.EntityFrameworkCore.Storage;
using System.Collections;

namespace Account.Application.Library.Patterns
{
    public class UnitOfWork<TContext> : IUnitOfWork
        where TContext : ContextDbApplication, new()
    {
        /// <summary>
        /// Dispose
        /// </summary>
        private bool _disposed;
        /// <summary>
        /// Transaction Channel
        /// </summary>
        private IDbContextTransaction  _objTran;
        /// <summary>
        /// DbContext Instance
        /// </summary>
        public TContext Context { get; }
        /// <summary>
        /// 
        /// </summary>
        private Hashtable _repositories;
        /// <summary>
        /// Dapper Service
        /// </summary>
        private DapperServices _Dapper;
        /// <summary>
        /// Dapper Service Injection
        /// </summary>
        public DapperServices Dapper { get => _Dapper ?? new DapperServices(); }
        public UnitOfWork()
        {
            Context = new TContext();
            _Dapper = new DapperServices();
        }
        public void BeginTransaction()
        {
            _objTran = Context.Database.BeginTransaction();
        }

        public void Commit()
        {
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

        public IGenericRepository<TEntity, TDTO, TView> Repository<TEntity, TDTO, TView>()
            where TEntity : BaseEntity, new()
            where TDTO : BaseDTO , new()
            where TView : BaseView, new()
        {
            if (_repositories == null)
                _repositories = new Hashtable();

            var type = typeof(TEntity).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(GenericRepository<TEntity,TDTO,TView>);

                var repositoryInstance =
                Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), Context);

                _repositories.Add(type, repositoryInstance);
            }

            return (IGenericRepository<TEntity, TDTO, TView>)_repositories[type];
        }
    }
}
