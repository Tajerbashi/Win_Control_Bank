using Infrastructure.Library.ApplicationContext.DapperService;
using Infrastructure.Library.ApplicationContext.EF;
using Infrastructure.Library.Extentions;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Library.Patterns
{
    public interface IUnitOfWork<out TContext> where TContext : DbContext, IDisposable, new()
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
        Paging Paging { get; }
        DapperServices Dapper { get; }

        #endregion


        //#region SEC
        //GroupService GroupService { get; }
        //GroupUserService GroupUserService { get; }
        //RoleService RoleService { get; }
        //UserService UserService { get; }
        //UserRoleService UserRoleService { get; }
        //#endregion

        //#region BUS
        //BankService BankService { get; }
        //BlanceService BlanceService { get; }
        //CartHistoryService CartHistoryService { get; }
        //CartService CartService { get; }
        //CustomerService CustomerService { get; }
        //TransactionService TransactionService { get; }
        //#endregion

        //#region BUS
        //WebServiceService WebServiceService { get; }

        //#endregion

    }
    public class UnitOfWork<TContext> : IUnitOfWork<TContext>
        where TContext : ContextDbApplication, new()
    {
        private TContext _Context;
        public TContext Context { get => _Context ?? new TContext(); }

        private Paging _Paging;
        public Paging Paging { get => _Paging ?? new Paging(); }

        private DapperServices _Dapper;
        public DapperServices Dapper { get => _Dapper ?? new DapperServices(); }
        public UnitOfWork()
        {
            _Context = new TContext();
            _Paging = new Paging();
            _Dapper = new DapperServices();
        }
        public void BeginTransaction()
        {
            //Context.Database.BeginTransaction();
            Context.BeginTransaction();
        }

        public void Commit()
        {
            //Context.Database.CommitTransaction();
            Context.CommitTransaction();
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        public void Rollback()
        {
            //Context.Database.RollbackTransaction();
            Context.RollBackTransaction();
        }

        public void Save()
        {
            Context.SaveChanges();
        }
    }
}
