using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.Patterns;
using Account.Infrastructure.Library.Repositories.RPT;

namespace Account.Infrastructure.Library.Services.RPT
{
    public class BankReportService : BankReportRepository
    {
        public BankReportService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
