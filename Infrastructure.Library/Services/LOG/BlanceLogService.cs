using AutoMapper;
using Infrastructure.Library.ApplicationContext.EF;
using Infrastructure.Library.Patterns;
using Infrastructure.Library.Repositories.LOG;

namespace Infrastructure.Library.Services.LOG
{
    public class BlanceLogService : BlanceLogRepository
    {
        public BlanceLogService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
