using AutoMapper;
using Infrastructure.Library.Repositories.BUS;
namespace Infrastructure.Library.Services.BUS
{
    public class CustomerService : CustomerRepository
    {
        public CustomerService(IMapper mapper) : base(mapper) { }
    }
}
