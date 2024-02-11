using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.Patterns;
using Account.Infrastructure.Library.Repositories.CNT;

namespace Account.Infrastructure.Library.Services.CNT
{
    public class ConstVariableService : ConstVariableRepository
    {
        public ConstVariableService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
