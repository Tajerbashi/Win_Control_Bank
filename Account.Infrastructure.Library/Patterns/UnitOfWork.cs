using Account.Application.Library.Patterns;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections;

namespace Account.Infrastructure.Library.Patterns
{
    public class UnitOfWork<TContext> : IUnitOfWork
        where TContext : ContextDbApplication
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
        /// Dapper Service Injection
        /// </summary>
        private readonly ContextDbApplication _context;
        public UnitOfWork(
            ContextDbApplication context

            )
        {
            _context = context;
        }
        public void BeginTransaction()
        {
            _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            _context.Database.CommitTransaction();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }

        public void Rollback()
        {
            _context.Database.RollbackTransaction();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
