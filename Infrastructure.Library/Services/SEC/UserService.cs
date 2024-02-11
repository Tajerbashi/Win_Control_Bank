using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.Patterns;
using Account.Infrastructure.Library.Repositories.SEC;

namespace Account.Infrastructure.Library.Services.SEC
{
    public class UserService : UserRepository
    {
        public UserService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
    }

}
