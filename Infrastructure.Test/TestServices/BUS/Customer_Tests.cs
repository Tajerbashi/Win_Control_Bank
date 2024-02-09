using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Test.Events.BUS;
using Infrastructure.Test.Exceptions;
using Infrastructure.Test.Services.BUS;

namespace Infrastructure.Test.TestServices.BUS
{
    public class Customer_Tests
    {
        [Fact]
        public void Create_NewCustomer_Enttiy()
        {
            //  Arrange
            CustomerTestService service = new CustomerTestService();

            //  Act
            var result = service.Create_NewCustomer_Model(new CustomerDTO
            {
                ID=0,
                Key = Guid.NewGuid(),
                FullName = "Test",

            });
            //  Asserts
            Assert.True(result.Result, result.Message);
        }
        [Fact]
        public void CustomerException_CheckId_AddOrUpdate()
        {
            //  Arrange
            CustomerTestService service = new CustomerTestService();
            //  Act

            //  Assert
            Assert.Throws<InvalidModelException>(() =>
            {
                service.FindData_CustomerGetById_Entity(0);
            });
        }
        [Fact]
        public void CustomerEvent_CheckStatusEvent_Key()
        {
            //  Arrange
            CustomerTestService service = new CustomerTestService();

            //  Act
            //  Assert
            Assert.Raises<CustomerStatusEventArgs>(
                handler => service.StatusChanged += handler,
                handler => service.StatusChanged -= handler,
                () => service.NotifyOfCustomerStatus(service.GetById(2))
                );
        }
    }
}
