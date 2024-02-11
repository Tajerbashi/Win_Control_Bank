using Account.Application.Library.ApplicationContext.DatabaseContext;
using Account.Application.Library.Patterns;
using Account.Application.Library.Repositories.SEC;

namespace Account.Application.Library.Services.SEC
{
    public class GroupUserService : GroupUserRepository
    {
        public GroupUserService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
    }

}
