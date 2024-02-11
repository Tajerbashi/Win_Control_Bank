using Account.Application.Library.ApplicationContext.DatabaseContext;
using Account.Application.Library.Patterns;
using Account.Application.Library.Repositories.SEC;

namespace Account.Application.Library.Services.SEC
{
    public class UserRoleService : UserRoleRepository
    {
        public UserRoleService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
    }

}
