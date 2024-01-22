using Infrastructure.Library.ApplicationContext.EF;
using Infrastructure.Library.Patterns;
using Infrastructure.Library.Repositories.LOG;

namespace Infrastructure.Library.Services.LOG
{
    public class CartLogService : CartLogRepository
    {
        public CartLogService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
