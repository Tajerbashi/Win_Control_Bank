using Domain.Library.Entities.LOG;
using Infrastructure.Library.BaseService;
using Infrastructure.Library.Models.DTOs.LOG;
using Infrastructure.Library.Models.Views.LOG;

namespace Infrastructure.Library.Repositories.LOG
{
    public abstract class CartLogRepository : GenericRepository<CartLog, CartLogDTO, CartLogView>
    {
    }
}
