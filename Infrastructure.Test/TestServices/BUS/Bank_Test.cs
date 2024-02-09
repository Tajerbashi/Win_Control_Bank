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
            BankTestService bankServiceTest = new BankTestService();
            //  Act
            var TestModel = bankServiceTest.Create_InsertBankData_Model(new BankDTO
            {
                ID = 11,
                BankName = "Test",
                Description = "Test",
                Title = "Test",
            });
            //  Assert
            Assert.True(TestModel.Result,TestModel.Message);

        }
    }
}
