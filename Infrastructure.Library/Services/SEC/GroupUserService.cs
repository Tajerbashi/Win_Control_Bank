using Infrastructure.Library.ApplicationContext.EF;
using Infrastructure.Library.Patterns;
using Infrastructure.Library.Repositories.SEC;

namespace Infrastructure.Library.Services.SEC
{
    public class GroupUserService : GroupUserRepository
    {
        public GroupUserService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
    }

}
