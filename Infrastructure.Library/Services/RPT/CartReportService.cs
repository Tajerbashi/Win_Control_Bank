using Infrastructure.Library.ApplicationContext.DatabaseContext;
using Infrastructure.Library.Patterns;
using Infrastructure.Library.Repositories.RPT;

namespace Infrastructure.Library.Services.RPT
{
    public class CartReportService : CartReportRepository
    {
        public CartReportService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
