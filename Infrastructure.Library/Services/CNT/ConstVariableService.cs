using Infrastructure.Library.ApplicationContext.DatabaseContext;
using Infrastructure.Library.Patterns;
using Infrastructure.Library.Repositories.CNT;

namespace Infrastructure.Library.Services.CNT
{
    public class ConstVariableService : ConstVariableRepository
    {
        public ConstVariableService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
