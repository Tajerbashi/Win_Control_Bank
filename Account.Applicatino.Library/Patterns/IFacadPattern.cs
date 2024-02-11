using Account.Application.Library.Extentions;
using Account.Application.Library.Repositories.BUS;
using Account.Application.Library.Repositories.CNT;
using Account.Application.Library.Repositories.LOG;
using Account.Application.Library.Repositories.RPT;
using Account.Application.Library.Repositories.SEC;
using System.Data;

namespace Account.Applicatino.Library.Patterns
{
    public interface IFacadPattern
    {
        DataTable ExecuteQuery(string query);
        Paging Paging { get; }

        #region SEC
        IUserRepository UserRepository { get; }
        IRoleRepository RoleRepository { get; }
        IUserRoleRepository UserRoleRepository { get; }
        IGroupRepository GroupRepository { get; }
        #endregion


        #region BUS
        IBankRepository BankRepository { get; }
        IBlanceRepository BlanceRepository { get; }
        ICartRepository CartRepository { get; }
        ICustomerRepository CustomerRepository { get; }
        #endregion


        #region RPT
        IBankReportRepository BankReportRepository { get; }
        ICartReportRepository CartReportRepository { get; }
        #endregion

        #region LOG
        INLogRepository NLogRepository { get; }
        #endregion


        #region CNT
        IConstVariableRepository ConstVariableRepository { get; }
        #endregion

        #region WEB
        #endregion
    }
}
