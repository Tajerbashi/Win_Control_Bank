using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Test.Services.BUS;

namespace Infrastructure.Test.TestServices.BUS
{
    public class Bank_Tests
    {
        [Fact]
        public void Create_Test()
        {
            //  Arrange
            BankServiceTest bankServiceTest = new BankServiceTest();
            //  Act
            var TestModel = bankServiceTest.CreateModel(new BankDTO
            {
                ID = 1,
                BankName = "Test",
                Description = "Test",
                Title = "Test",
            });
            //  Assert
            Assert.True(TestModel);

        }
    }
}
