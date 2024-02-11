using Account.Applicatino.Library.Patterns;
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
        private UnitOfWork<ContextDbApplication> _unitOfWork;

        public Paging Paging { get; set; }

        private UserRepository _userRepository;
        public IUserRepository UserRepository { get => _userRepository; }

        private RoleRepository _roleRepository;
        public IRoleRepository RoleRepository { get => _roleRepository; }

        private UserRoleRepository _userRoleRepository;
        public IUserRoleRepository UserRoleRepository { get => _userRoleRepository; }

        private GroupRepository _groupRepository;
        public IGroupRepository GroupRepository { get => _groupRepository; }

        private BankRepository _bankRepository;
        public IBankRepository BankRepository { get => _bankRepository; }

        private BlanceRepository _blanceRepository;
        public IBlanceRepository BlanceRepository { get => _blanceRepository; }

        private CartRepository _cartRepository;
        public ICartRepository CartRepository { get => _cartRepository; }

        private CustomerRepository _customerRepository;
        public ICustomerRepository CustomerRepository { get => _customerRepository; }

        private BankReportRepository _bankReportRepository;
        public IBankReportRepository BankReportRepository { get => _bankReportRepository; }

        private CartReportRepository _cartReportRepository;
        public ICartReportRepository CartReportRepository { get => _cartReportRepository; }

        private NLogRepository _nLogRepository;
        public INLogRepository NLogRepository { get => _nLogRepository; }

        private ConstVariableRepository _constVariableRepository;
        public IConstVariableRepository ConstVariableRepository { get => _constVariableRepository; }

        public IExecuteDataTableQuery ExecuteQueryGrid { get; set; }

        public IUnitOfWork UnitOfWork { get => _unitOfWork; }

        public DataTable ExecuteQuery(string query)
        {
            return ExecuteQueryGrid.Execute(query);
        }


    }
}
