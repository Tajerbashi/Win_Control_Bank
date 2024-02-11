using Account.Application.Library.BaseService;
using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Models.Views.BUS;
using Account.Domain.Library.Entities.BUS;

namespace Account.Application.Library.Repositories.BUS
{
    public interface IBlanceRepository : IGenericRepository<Blance,BlanceDTO,BlanceView>, IBaseQueries
    {
        string Show50LastTransactions(string paging);
        string ShowAllByCartId(long cartId,string paging);
        double GetBlanceCartById(long cartId);
        void DisActiveLastBlanceOfCartById(long cartId);
        IEnumerable<KeyValue<byte>> TitleValueTransactionType();
        IEnumerable<KeyValue<byte>> TitleValueBlanceType();
    }
}
