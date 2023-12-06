using Domain.Library.Entities.BUS;
using Infrastructure.Library.BaseService;
using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Library.Models.Views.BUS;

namespace Infrastructure.Library.Repositories.BUS
{
    public abstract class CartHistoryRepository : GenericRepository<CartHistory, CartHistoryDTO, CartHistoryView>
    {
    }
}
