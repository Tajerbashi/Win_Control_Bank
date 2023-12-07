using AutoMapper;
using Infrastructure.Library.Repositories.RPT;

namespace Infrastructure.Library.Services.RPT
{
    public class TransactionReportService : TransactionReportRepository
    {
        public TransactionReportService(IMapper mapper) : base(mapper)
        {
        }
    }
}
