using AutoMapper;
using Infrastructure.Library.Repositories.BUS;

namespace Infrastructure.Library.Services.BUS
{
    public class BankService : BankRepository
    {
        public BankService(IMapper mapper) : base(mapper)
        {
        }
    }
}
