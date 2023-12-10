using AutoMapper;
using Infrastructure.Library.Repositories.BUS;

namespace Infrastructure.Library.Services.BUS
{
    public class CartService : CartRepository
    {
        public CartService(IMapper mapper) : base(mapper)
        {
        }
        
    }
}
