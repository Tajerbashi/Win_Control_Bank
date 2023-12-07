using AutoMapper;
using Infrastructure.Library.Repositories.RPT;

namespace Infrastructure.Library.Services.RPT
{
    public class BankReportService : BankReportRepository
    {
        protected BankReportService(IMapper mapper) : base(mapper)
        {
        }
    }
}
