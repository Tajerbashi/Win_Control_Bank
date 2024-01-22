using Infrastructure.Library.ApplicationContext.EF;
using Infrastructure.Library.Patterns;
using Infrastructure.Library.Repositories.BUS;
namespace Infrastructure.Library.Services.BUS
{
    public class CustomerService : CustomerRepository
    {
        public CustomerService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
