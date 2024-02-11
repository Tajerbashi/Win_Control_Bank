using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.Patterns;
using Account.Infrastructure.Library.Repositories.RPT;

namespace Account.Infrastructure.Library.Services.RPT
{
    public class CartReportService : CartReportRepository
    {
        public CartReportService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
