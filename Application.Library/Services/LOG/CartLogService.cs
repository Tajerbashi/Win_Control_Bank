using AutoMapper;
using Infrastructure.Library.Repositories.LOG;

namespace Infrastructure.Library.Services.LOG
{
    public class CartLogService : CartLogRepository
    {
        public CartLogService(IMapper mapper) : base(mapper)
        {
        }
    }
}
