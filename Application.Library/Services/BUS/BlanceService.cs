using AutoMapper;
using Infrastructure.Library.Repositories.BUS;

namespace Infrastructure.Library.Services.BUS
{
    public class BlanceService : BlanceRepository
    {
        public BlanceService(IMapper mapper) : base(mapper)
        {
        }
    }
}
