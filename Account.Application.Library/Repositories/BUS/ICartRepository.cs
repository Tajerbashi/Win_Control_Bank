using Account.Application.Library.BaseService;
using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Models.Views.BUS;
using Account.Domain.Library.Entities.BUS;

namespace Account.Application.Library.Repositories.BUS
{
    public interface ICartRepository : IGenericRepository<Cart, CartDTO, CartView>, IBaseQueries
    {
        IEnumerable<KeyValue<long>> TitleValuesParent();
        CartDTO GetCartByAccountNumber(string number);
        IEnumerable<KeyValue<long>> TitleValuesAllParentCart();
        IEnumerable<KeyValue<long>> TitleValuesAllCart();
        IEnumerable<KeyValue<long>> TitleValuesCartByBankId(long Id);
        IEnumerable<KeyValue<long>> TitleValuesChild(long Id);
        IEnumerable<KeyValue<long>> TitleValueByUser(long Id);
        bool ValidBankBlance(long cartId,double cash);
        string SearchByCartId(long cartId, string paging);

    }
}
