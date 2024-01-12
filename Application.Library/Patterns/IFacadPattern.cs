using Infrastructure.Library.ApplicationContext.EF;
using Infrastructure.Library.ApplicationContext.GridDataConnection;
using Infrastructure.Library.Services.BUS;
using Infrastructure.Library.Services.SEC;
using System.Data;

namespace Infrastructure.Library.Patterns
{
    public interface IFacadPattern
    {
        UnitOfWork<ContextDbApplication> UnitOfWork { get; }
        DataTable ExecuteQuery(string query);

        #region SEC
        UserService UserService { get; }
        RoleService RoleService { get; }
        UserRoleService UserRoleService { get; }
        GroupService GroupService { get; }
        GroupUserService GroupUserService { get; }
        #endregion


        #region BUS
        BankService BankService { get; }
        BlanceService BlanceService { get; }
        CartService CartService { get; }
        CartHistoryService CartHistoryService { get; }
        CustomerService CustomerService { get; }
        TransactionService TransactionService { get; }
        #endregion


        #region RPT
        #endregion


        #region LOG
        #endregion


        #region CNT
        #endregion

        #region WEB
        #endregion
    }
    public class FacadPattern : IFacadPattern
    {
        public UnitOfWork<ContextDbApplication> UnitOfWork { get => new UnitOfWork<ContextDbApplication>(); }
        private IBaseQuery _gridQuery;
        protected IBaseQuery GridQuery { get => _gridQuery = _gridQuery ?? new BaseQuery(); }

        public UserService UserService => throw new NotImplementedException();

        public RoleService RoleService => throw new NotImplementedException();

        public UserRoleService UserRoleService => throw new NotImplementedException();

        public GroupService GroupService => throw new NotImplementedException();

        public GroupUserService GroupUserService => throw new NotImplementedException();

        public BankService BankService => throw new NotImplementedException();

        public BlanceService BlanceService => throw new NotImplementedException();

        public CartService CartService => throw new NotImplementedException();

        public CartHistoryService CartHistoryService => throw new NotImplementedException();

        public CustomerService CustomerService => throw new NotImplementedException();

        public TransactionService TransactionService => throw new NotImplementedException();

        public DataTable ExecuteQuery(string query)
        {
            return GridQuery.Execute(query);
        }


    }
}
