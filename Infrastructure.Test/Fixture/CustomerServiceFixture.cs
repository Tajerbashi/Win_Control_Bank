using Infrastructure.Test.Repositories.BUS;
using Infrastructure.Test.Services.BUS;

namespace Infrastructure.Test.Fixture
{
    public class CustomerServiceFixture : IDisposable
    {
        public ICustomerTestRepository customerTestRepository { get; }
        public CustomerServiceFixture()
        {
            customerTestRepository = new CustomerTestService();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
