using Dapper;
using Account.Application.Library.ApplicationContext.DatabaseContext;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Patterns;
using Account.Application.Library.Repositories.BUS;
namespace Account.Application.Library.Services.BUS
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
