using Account.Application.Library.BaseService;
using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Models.Views.BUS;
using Account.Domain.Library.Entities.BUS;

namespace Account.Application.Library.Repositories.BUS
{
    public interface IBankRepository : IGenericRepository<Bank, BankDTO, BankView>, IBaseQueries
    {
        /// <summary>
        /// دریافت مدل بانک براساس نام بانک
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        BankDTO GetBankByName(string name);
        /// <summary>
        /// دریافت اسامی بانک بر اساس کلید و مقدار
        /// </summary>
        /// <returns></returns>
        IEnumerable<KeyValue<long>> BankTitleValue();

    }
}
