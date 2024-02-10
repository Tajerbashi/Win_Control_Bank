using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Test.BaseTests;
using Infrastructure.Test.Events.BUS;
using Infrastructure.Test.Models;

namespace Infrastructure.Test.Repositories.BUS
{
    public interface ICustomerTestRepository : IBaseTestRepository<CustomerDTO>
    {
        event EventHandler<CustomerStatusEventArgs>? StatusChanged;
        ResultTest<bool> Create_NewCustomer_Model(CustomerDTO customer);
        ResultTest<bool> Update_CustomerNewData_Model(CustomerDTO customer);
        ResultTest<bool> Check_DuplicateCustomer_Model(CustomerDTO customer);
        void NotifyOfCustomerStatus(CustomerDTO customer);
        ResultTest<bool> FindData_CustomerGetById_Entity(long id);
    }
}
