using AutoMapper;
using Infrastructure.Library.Repositories.RPT;

namespace Infrastructure.Library.Services.RPT
{
    public class TransferReportService : TransferReportRepository
    {
        public TransferReportService(IMapper mapper) : base(mapper)
        {
        }
    }
}
