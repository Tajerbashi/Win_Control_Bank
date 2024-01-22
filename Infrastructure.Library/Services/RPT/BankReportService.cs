using Infrastructure.Library.ApplicationContext.EF;
using Infrastructure.Library.Patterns;
using Infrastructure.Library.Repositories.RPT;

namespace Infrastructure.Library.Services.RPT
{
    public class BankReportService : BankReportRepository
    {
        public BankReportService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
