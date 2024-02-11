using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.Patterns;
using Account.Infrastructure.Library.Repositories.SEC;

namespace Account.Infrastructure.Library.Services.SEC
{
    public class RoleService : RoleRepository
    {
        public RoleService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
    }

}
