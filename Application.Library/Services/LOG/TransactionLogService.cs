using AutoMapper;
using Infrastructure.Library.Repositories.LOG;

namespace Infrastructure.Library.Services.LOG
{
    public class TransactionLogService : TransactionLogRepository
    {
        public TransactionLogService(IMapper mapper) : base(mapper)
        {
        }
    }
}
