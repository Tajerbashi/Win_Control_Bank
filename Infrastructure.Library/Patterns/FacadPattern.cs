using Account.Applicatino.Library.Patterns;
using Account.Application.Library.ApplicationContext.DatabaseContext;
using Account.Application.Library.ApplicationContext.GridDataConnection;
using Account.Application.Library.Extentions;
using Account.Application.Library.Services.BUS;
using Account.Application.Library.Services.CNT;
using Account.Application.Library.Services.LOG;
using Account.Application.Library.Services.RPT;
using Account.Application.Library.Services.SEC;
using System.Data;

namespace Account.Application.Library.Patterns
{

    public class FacadPattern : IFacadPattern
    {
        private UnitOfWork<ContextDbApplication> _unitOfWork;
        public UnitOfWork<ContextDbApplication> UnitOfWork
        {
            get => _unitOfWork = _unitOfWork ?? new UnitOfWork<ContextDbApplication>();
            set => UnitOfWork = _unitOfWork;
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
        private NLogService _nLogService ;
        public NLogService NLogService => _nLogService ?? new NLogService(UnitOfWork);









        #endregion

        #region WEB
        #endregion



        public DataTable ExecuteQuery(string query)
        {
            return GridQuery.Execute(query);
        }


    }
}
