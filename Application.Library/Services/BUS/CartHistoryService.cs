using AutoMapper;
using Infrastructure.Library.Repositories.BUS;

namespace Infrastructure.Library.Services.BUS
{
    public class CartHistoryService : CartHistoryRepository
    {
        public CartHistoryService(IMapper mapper) : base(mapper)
        {
        }
    }
}
