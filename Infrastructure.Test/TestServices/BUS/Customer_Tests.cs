using Account.Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Test.Events.BUS;
using Infrastructure.Test.Exceptions;
using Infrastructure.Test.Fixture;
using Infrastructure.Test.Services.BUS;

namespace Infrastructure.Test.TestServices.BUS
{
    [Collection("CustomerServiceCollection")]
    public class Customer_Tests //: IClassFixture<CustomerServiceFixture>
    {
        private readonly CustomerServiceFixture _fixture;
        public Customer_Tests(CustomerServiceFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Create_NewCustomer_Enttiy()
        {
            //  Act
            var result = _fixture.customerTestRepository.Create_NewCustomer_Model(new CustomerDTO
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
                _fixture.customerTestRepository.FindData_CustomerGetById_Entity(0);
            });
        }
        
        [Fact]
        public void CustomerEvent_CheckStatusEvent_Key()
        {
            //  Act
            //  Assert
            Assert.Raises<CustomerStatusEventArgs>(
                handler => _fixture.customerTestRepository.StatusChanged += handler,
                handler => _fixture.customerTestRepository.StatusChanged -= handler,
                () => _fixture.customerTestRepository.NotifyOfCustomerStatus(_fixture.customerTestRepository.GetById(2))
                );
        }
    }
}
