using Domain.Library.Entities.RPT;
using Infrastructure.Library.BaseService;
using Infrastructure.Library.Models.DTOs.RPT;
using Infrastructure.Library.Models.Views.RPT;

namespace Infrastructure.Library.Repositories.RPT
{
    public abstract class CartReportRepository : GenericRepository<CartReport, CartReportDTO, CartReportView>
    {
    }
}
