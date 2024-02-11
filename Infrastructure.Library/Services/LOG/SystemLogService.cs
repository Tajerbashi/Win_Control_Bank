using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.Patterns;
using Account.Infrastructure.Library.Repositories.LOG;

namespace Account.Infrastructure.Library.Services.LOG
{
    public class NLogService : NLogRepository
    {
        public NLogService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
