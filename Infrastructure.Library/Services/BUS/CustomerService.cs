using Dapper;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.Models.DTOs.BUS;
using Account.Infrastructure.Library.Patterns;
using Account.Infrastructure.Library.Repositories.BUS;
namespace Account.Infrastructure.Library.Services.BUS
{
    public class CustomerService : CustomerRepository
    {
        public CustomerService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }

        public CustomerDTO GetCustomerByName(string name)
        {
            var result  = base.DapperServices.QueryFirstOrDefault<CustomerDTO>(@"
SELECT *
FROM BUS.Customers CS
WHERE CS.FullName LIKE @Name
AND CS.IsDeleted = 0 
AND CS.IsActive = 1
", new
            {
                Name = name,
            });
            //base.Search(name);
            return result;
        }
    }
}
