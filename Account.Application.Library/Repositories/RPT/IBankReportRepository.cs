using Account.Application.Library.BaseService;
using Account.Application.Library.Models.DTOs.RPT;
using Account.Application.Library.Models.Views.RPT;
using Account.Domain.Library.Entities.RPT;

namespace Account.Application.Library.Repositories.RPT
{
    public interface IBankReportRepository : IGenericRepository<BankReport, BankReportDTO, BankReportView>, IBaseQueries
    {
    }
}
