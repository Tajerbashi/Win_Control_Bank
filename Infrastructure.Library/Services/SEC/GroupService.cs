using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.Patterns;
using Account.Infrastructure.Library.Repositories.SEC;

namespace Account.Infrastructure.Library.Services.SEC
{
    public class GroupService : GroupRepository
    {
        public GroupService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
    }

}
