using Domain.Library.Entities.BUS;
using Infrastructure.Library.BaseService;
using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Library.Models.Views.BUS;
using System.Runtime.CompilerServices;

namespace Infrastructure.Library.Repositories.BUS
{
    public abstract class CustomerRepository : GenericRepository<Customer, CustomerDTO, CustomerView>
    {
    }
}
