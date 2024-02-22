using Account.Application.Library.BaseService;
using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Models.Views.BUS;
using Account.Domain.Library.Entities.BUS;

namespace Account.Application.Library.Repositories.BUS
{
    public interface IBankRepository : IGenericRepository<Bank, BankDTO, BankView>, IBaseQueries
    {
        BankDTO GetBankByName(string name);
        IEnumerable<KeyValue<long>> BankTitleValue();

    }
}
