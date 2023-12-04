using Infrastructure.Library.Services.BUS;
using Infrastructure.Library.Services.SEC;

namespace Infrastructure.Library.Patterns
{
    public interface IUnitOfWork
    {
        #region SEC
        public GroupService GroupService { get; }
        public GroupUserService GroupUserService { get; }
        public RoleService RoleService { get; }
        public UserService UserService { get; }
        public UserRoleService UserRoleService { get; }
        public UserRoleGroupService UserRoleGroupService { get; }
        #endregion

        #region BUS
        public BankService BankService { get; }
        public BlanceService BlanceService { get; }
        public CartHistoryService CartHistoryService { get; }
        public CartService CartService { get; }
        public CustomerService CustomerService { get; }
        public TransactionService TransactionService { get; }
        #endregion
    }
    public class UnitOfWork : IUnitOfWork
    {
        #region SEC
        private GroupService _groupService;
        public GroupService GroupService
        {
            get => _groupService = _groupService ?? new GroupService();
        }
        private GroupUserService _groupUserService;
        public GroupUserService GroupUserService
        {
            get => _groupUserService ?? new GroupUserService();
        }

        private RoleService _roleService;
        public RoleService RoleService
        {
            get => _roleService ?? new RoleService();
        }

        private UserService _userService;
        public UserService UserService
        {
            get => (_userService ?? new UserService());
        }

        private UserRoleService _userRoleService;
        public UserRoleService UserRoleService
        {
            get => _userRoleService ?? new UserRoleService();
        }

        private UserRoleGroupService _userRoleGroupService;
        public UserRoleGroupService UserRoleGroupService
        {
            get => _userRoleGroupService ?? new UserRoleGroupService();
        }


        #endregion

        #region BUS
        private BankService _BankService;
        public BankService BankService
        {
            get => _BankService ?? new BankService();
        }

        private BlanceService _BlanceService;
        public BlanceService BlanceService
        {
            get => _BlanceService ?? new BlanceService();
        }
       
        private CartHistoryService _CartHistoryService;
        public CartHistoryService CartHistoryService
        {
            get => _CartHistoryService ?? new CartHistoryService();
        }
       
        private CartService _CartService;
        public CartService CartService
        {
            get => _CartService ?? new CartService();
        }
       
        private CustomerService _CustomerService;
        public CustomerService CustomerService
        {
            get => _CustomerService ?? new CustomerService();
        }
       
        private TransactionService _TransactionService;
        public TransactionService TransactionService
        {
            get => _TransactionService ?? new TransactionService();
        }
        #endregion

    }
}
