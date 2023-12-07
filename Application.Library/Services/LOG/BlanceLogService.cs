using AutoMapper;
using Infrastructure.Library.Repositories.LOG;

namespace Infrastructure.Library.Services.LOG
{
    public class BlanceLogService : BlanceLogRepository
    {
        public BlanceLogService(IMapper mapper) : base(mapper)
        {
        }
    }
}
