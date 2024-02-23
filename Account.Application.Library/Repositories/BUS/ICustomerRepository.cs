using Account.Application.Library.BaseService;
using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Models.Views.BUS;
using Account.Domain.Library.Entities.BUS;

namespace Account.Application.Library.Repositories.BUS
{
    public interface ICustomerRepository : IGenericRepository<Customer, CustomerDTO, CustomerView>, IBaseQueries
    {
        /// <summary>
        /// دریافت مدل مشترک بر اساس نام
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        CustomerDTO GetCustomerByName(string name);

        /// <summary>
        /// نام و آیدی مشترک
        /// </summary>
        /// <returns></returns>
        IEnumerable<KeyValue<long>> CustomerTitleValue();
    }
}
