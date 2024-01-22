using Infrastructure.Library.ApplicationContext.EF;
using Infrastructure.Library.Patterns;
using Infrastructure.Library.Repositories.BUS;

namespace Infrastructure.Library.Services.BUS
{
    public class BankService : BankRepository
    {
        public BankService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
