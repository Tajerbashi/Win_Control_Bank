using Dapper;
using Infrastructure.Library.ApplicationContext.EF;
using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Library.Patterns;
using Infrastructure.Library.Repositories.BUS;
namespace Infrastructure.Library.Services.BUS
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
