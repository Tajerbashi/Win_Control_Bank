using AutoMapper;
using Infrastructure.Library.Repositories.RPT;

namespace Infrastructure.Library.Services.RPT
{
    public class CartReportService : CartReportRepository
    {
        protected CartReportService(IMapper mapper) : base(mapper)
        {
        }
    }
}
