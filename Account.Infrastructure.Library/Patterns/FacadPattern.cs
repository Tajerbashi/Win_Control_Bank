using Account.Application.Library.ApplicationContext.DatabaseContext;
using Account.Application.Library.Extentions;
using Account.Application.Library.IDatabaseContext.DatabaseContext;
using Account.Application.Library.Repositories.BUS;
using Account.Application.Library.Repositories.CNT;
using Account.Application.Library.Repositories.LOG;
using Account.Application.Library.Repositories.RPT;
using Account.Application.Library.Repositories.SEC;
using Account.Infrastructure.Library.ApplicationContext.GridDataConnection;
using System.Data;

namespace Account.Application.Library.Patterns
{

    public class FacadPattern : IFacadPattern
    {
        public IUnitOfWork UnitOfWork { get => new UnitOfWork<ContextDbApplication>(); }
        public UnitOfWork<ContextDbApplication> _unitOfWork;
        public FacadPattern()
        {
            _unitOfWork = new UnitOfWork<ContextDbApplication>();
        }

        public Paging Paging { get => new Paging(); }

        private UserRepository _userRepository;
        public IUserRepository UserRepository { get => _userRepository = _userRepository ?? new UserRepository(_unitOfWork); }

        private RoleRepository _roleRepository;
        public IRoleRepository RoleRepository { get => _roleRepository = _roleRepository ?? new RoleRepository(_unitOfWork); }

        private UserRoleRepository _userRoleRepository;
        public IUserRoleRepository UserRoleRepository { get => _userRoleRepository ?? new UserRoleRepository(_unitOfWork); }

        private GroupRepository _groupRepository;
        public IGroupRepository GroupRepository { get => _groupRepository = _groupRepository ?? new GroupRepository(_unitOfWork); }

        private BankRepository _bankRepository;
        public IBankRepository BankRepository { get => _bankRepository = _bankRepository ?? new BankRepository(_unitOfWork); }

        private BlanceRepository _blanceRepository;
        public IBlanceRepository BlanceRepository { get => _blanceRepository = _blanceRepository ?? new BlanceRepository(_unitOfWork); }

        private CartRepository _cartRepository;
        public ICartRepository CartRepository { get => _cartRepository = _cartRepository ?? new CartRepository(_unitOfWork); }

        private CustomerRepository _customerRepository;
        public ICustomerRepository CustomerRepository { get => _customerRepository = _customerRepository ?? new CustomerRepository(_unitOfWork); }

        private BankReportRepository _bankReportRepository;
        public IBankReportRepository BankReportRepository { get => _bankReportRepository = _bankReportRepository ?? new BankReportRepository(_unitOfWork); }

        private CartReportRepository _cartReportRepository;
        public ICartReportRepository CartReportRepository { get => _cartReportRepository = _cartReportRepository ?? new CartReportRepository(_unitOfWork); }

        private NLogRepository _nLogRepository;
        public INLogRepository NLogRepository { get => _nLogRepository = _nLogRepository ?? new NLogRepository(_unitOfWork); }

        private ConstVariableRepository _constVariableRepository;
        public IConstVariableRepository ConstVariableRepository { get => _constVariableRepository = _constVariableRepository ?? new ConstVariableRepository(_unitOfWork); }

        private ExecuteDataTableQuery _executeQueryGrid;
        public IExecuteDataTableQuery ExecuteQueryGrid { get => _executeQueryGrid = _executeQueryGrid ?? new ExecuteDataTableQuery(); }


        public DataTable ExecuteQuery(string query)
        {
            return ExecuteQueryGrid.Execute(query);
        }
    }
}
