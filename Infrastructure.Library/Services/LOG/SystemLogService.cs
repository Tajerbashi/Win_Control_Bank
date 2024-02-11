using Account.Application.Library.ApplicationContext.DatabaseContext;
using Account.Application.Library.Patterns;
using Account.Application.Library.Repositories.LOG;

namespace Account.Application.Library.Services.LOG
{
    public class NLogService : NLogRepository
    {
        public NLogService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
