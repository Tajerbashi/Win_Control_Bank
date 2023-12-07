using AutoMapper;
using Infrastructure.Library.Repositories.BUS;

namespace Infrastructure.Library.Services.BUS
{
    public class TransactionService : TransactionRepository
    {
        public TransactionService(IMapper mapper) : base(mapper)
        {
        }
    }
}
