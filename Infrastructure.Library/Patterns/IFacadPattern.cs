using Infrastructure.Library.ApplicationContext.EF;
using Infrastructure.Library.ApplicationContext.GridDataConnection;
using Infrastructure.Library.Extentions;
using Infrastructure.Library.Services.BUS;
using Infrastructure.Library.Services.CNT;
using Infrastructure.Library.Services.HSR;
using Infrastructure.Library.Services.LOG;
using Infrastructure.Library.Services.RPT;
using Infrastructure.Library.Services.SEC;
using System.Data;

namespace Infrastructure.Library.Patterns
{
    public interface IFacadPattern
    {
        UnitOfWork<ContextDbApplication> UnitOfWork { get; set; }
        DataTable ExecuteQuery(string query);
        Paging Paging { get; }

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
        CustomerService CustomerService { get; }
        #endregion


        #region RPT
        BankReportService BankReportService { get; }
        CartReportService CartReportService { get; }
        #endregion

        #region HSR
        CartHistoryService CartHistoryService { get; }
        #endregion

        #region LOG
        SystemLogService SystemLogService { get; }
        #endregion


        #region CNT
        ConstVariableService ConstVariableService { get; }
        #endregion

        #region WEB
        #endregion
    }
    public class FacadPattern : IFacadPattern
    {
        private UnitOfWork<ContextDbApplication> _unitOfWork;
        public UnitOfWork<ContextDbApplication> UnitOfWork { 
            get => _unitOfWork = _unitOfWork ?? new UnitOfWork<ContextDbApplication>();
            set => UnitOfWork=_unitOfWork;
        }
        private Paging _paging;
        public Paging Paging => _paging ?? new Paging();


        private IBaseQuery _gridQuery;
        protected IBaseQuery GridQuery { get => _gridQuery = _gridQuery ?? new BaseQuery(); }

        #region SEC
        private UserService _userService;
        public UserService UserService => _userService ?? new UserService(UnitOfWork);

        private RoleService _roleService;
        public RoleService RoleService => _roleService ?? new RoleService(UnitOfWork);

        private UserRoleService _userRoleService ;
        public UserRoleService UserRoleService => _userRoleService ?? new UserRoleService(UnitOfWork);

        private GroupService _groupService ;
        public GroupService GroupService => _groupService ?? new GroupService(UnitOfWork);

        private GroupUserService _groupUserService ;
        public GroupUserService GroupUserService => _groupUserService ?? new GroupUserService(UnitOfWork);
        #endregion

        #region BUS
        private BankService _bankService ;
        public BankService BankService => _bankService ?? new BankService(UnitOfWork);

        private BlanceService _blanceService ;
        public BlanceService BlanceService => _blanceService ?? new BlanceService(UnitOfWork);

        private CartService _cartService ;
        public CartService CartService => _cartService ?? new CartService(UnitOfWork);


        private CustomerService _customerService ;
        public CustomerService CustomerService => _customerService ?? new CustomerService(UnitOfWork);

        #endregion

        #region CNT
        private ConstVariableService _constVariableService ;
        public ConstVariableService ConstVariableService => _constVariableService ?? new ConstVariableService(UnitOfWork);
        #endregion

        #region RPT
        private BankReportService _bankReportService ;
        public BankReportService BankReportService => _bankReportService ?? new BankReportService(UnitOfWork);

        private CartReportService _cartReportService ;
        public CartReportService CartReportService => _cartReportService ?? new CartReportService(UnitOfWork);


        #endregion

        #region LOG
        private SystemLogService _systemLogService ;
        public SystemLogService SystemLogService => _systemLogService ?? new SystemLogService(UnitOfWork);









        #endregion

        #region WEB
        #endregion

        #region HSR
        private CartHistoryService _cartHistoryService ;
        public CartHistoryService CartHistoryService => _cartHistoryService ?? new CartHistoryService(UnitOfWork);
        #endregion


        public DataTable ExecuteQuery(string query)
        {
            return GridQuery.Execute(query);
        }


    }
}
