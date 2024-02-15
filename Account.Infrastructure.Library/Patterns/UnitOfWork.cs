using Account.Application.Library.Patterns;
using Account.Application.Library.Repositories.BUS;
using Account.Application.Library.Repositories.CNT;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections;

namespace Account.Infrastructure.Library.Patterns
{
    public class UnitOfWork : IUnitOfWork
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
        private readonly ContextDbApplication Context;
        /// <summary>
        /// 
        /// </summary>
        private Hashtable _repositories;

        public ICustomerRepository CustomerRepository { get; }

        public IBankRepository BankRepository { get; }

        public IBlanceRepository BlanceRepository { get; }

        public ICartRepository CartRepository { get; }

        public IConstVariableRepository ConstVariableRepository { get; }

        /// <summary>
        /// Dapper Service Injection
        /// </summary>
        public UnitOfWork(
            ContextDbApplication context,
            ICustomerRepository customerRepository,
            IBankRepository bankRepository,
            IBlanceRepository blanceRepository,
            ICartRepository cartRepository,
            IConstVariableRepository constVariableRepository
            )
        {
            Context = context;
            CustomerRepository = customerRepository;
            BankRepository = bankRepository;
            BlanceRepository = blanceRepository;
            CartRepository = cartRepository;
            ConstVariableRepository = constVariableRepository;

        }
        public void BeginTransaction()
        {
            Context.Database.BeginTransaction();
        }

        public void Commit()
        {
            Context.Database.CommitTransaction();
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
                Context.Dispose();
            }
        }

        public void Rollback()
        {
            Context.Database.RollbackTransaction();
        }

        public int Save()
        {
            return Context.SaveChanges();
        }
    }
}
