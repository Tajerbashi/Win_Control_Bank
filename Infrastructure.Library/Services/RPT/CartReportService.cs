using Account.Application.Library.ApplicationContext.DatabaseContext;
using Account.Application.Library.Patterns;
using Account.Application.Library.Repositories.RPT;

namespace Account.Application.Library.Services.RPT
{
    public class CartReportService : CartReportRepository
    {
        public CartReportService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
