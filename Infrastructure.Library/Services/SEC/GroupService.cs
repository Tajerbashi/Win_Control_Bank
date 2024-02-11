using Account.Application.Library.ApplicationContext.DatabaseContext;
using Account.Application.Library.Patterns;
using Account.Application.Library.Repositories.SEC;

namespace Account.Application.Library.Services.SEC
{
    public class GroupService : GroupRepository
    {
        public GroupService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
    }

}
