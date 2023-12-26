using AutoMapper;
using Infrastructure.Library.ApplicationContext.DapperService;
using Infrastructure.Library.ApplicationContext.EF;
using Infrastructure.Library.Extentions;
using Infrastructure.Library.Services.BUS;
using Infrastructure.Library.Services.SEC;
using Microsoft.EntityFrameworkCore.Storage;

namespace Infrastructure.Library.Patterns
{
    public interface IUnitOfWork:IDisposable
    {


        #region Config
        Paging Paging { get; }
        DapperServices Dapper { get; }

        IDbContextTransaction BeginTransaction();
        void CommitTransaction();
        void RollBackTransaction();
        #endregion


        #region SEC
        GroupService GroupService { get; }
        GroupUserService GroupUserService { get; }
        RoleService RoleService { get; }
        UserService UserService { get; }
        UserRoleService UserRoleService { get; }
        #endregion

        #region BUS
        BankService BankService { get; }
        BlanceService BlanceService { get; }
        CartHistoryService CartHistoryService { get; }
        CartService CartService { get; }
        CustomerService CustomerService { get; }
        TransactionService TransactionService { get; }
        #endregion

    }
    public class UnitOfWork : IUnitOfWork
    {
        #region Configs

        private readonly IContextDbApplication _context;
        private readonly IMapper mapper;
        private DapperServices _dapper;
        public DapperServices Dapper { get => _dapper = _dapper ?? new DapperServices(); }
        private Paging _paging;
        public Paging Paging
        {
            get => _paging = _paging ?? new Paging();
        }
        #endregion

        public UnitOfWork()
        {
            _context = new ContextDbApplication();
        }


        #region SEC
        private GroupService _groupService;
        public GroupService GroupService
        {
            get => _groupService = _groupService ?? new GroupService(mapper);
        }
        private GroupUserService _groupUserService;
        public GroupUserService GroupUserService
        {
            get => _groupUserService ?? new GroupUserService(mapper);
        }

        private RoleService _roleService;
        public RoleService RoleService
        {
            get => _roleService ?? new RoleService(mapper);
        }

        private UserService _userService;
        public UserService UserService
        {
            get => (_userService ?? new UserService(mapper));
        }

        private UserRoleService _userRoleService;
        public UserRoleService UserRoleService
        {
            get => _userRoleService ?? new UserRoleService(mapper);
        }


        #endregion

        #region BUS
        private BankService _BankService;
        public BankService BankService
        {
            get => _BankService ?? new BankService(mapper);
        }

        private BlanceService _BlanceService;
        public BlanceService BlanceService
        {
            get => _BlanceService ?? new BlanceService(mapper);
        }

        private CartHistoryService _CartHistoryService;
        public CartHistoryService CartHistoryService
        {
            get => _CartHistoryService ?? new CartHistoryService(mapper);
        }

        private CartService _CartService;
        public CartService CartService
        {
            get => _CartService ?? new CartService(mapper);
        }

        private CustomerService _CustomerService;
        public CustomerService CustomerService
        {
            get => _CustomerService ?? new CustomerService(mapper);
        }

        private TransactionService _TransactionService;
        public TransactionService TransactionService
        {
            get => _TransactionService ?? new TransactionService(mapper);
        }

        public void Dispose()
        {
        }

        public IDbContextTransaction BeginTransaction()
        {
            return _context.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _context.CommitTransaction();
        }

        public void RollBackTransaction()
        {
            _context.RollBackTransaction();
        }

        #endregion

    }
}
