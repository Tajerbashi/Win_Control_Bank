using Account.Application.Library.ApplicationContext.DatabaseContext;
using Account.Application.Library.Patterns;
using Account.Application.Library.Repositories.CNT;

namespace Account.Application.Library.Services.CNT
{
    public class ConstVariableService : ConstVariableRepository
    {
        public ConstVariableService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
