using AutoMapper;
using Domain.Library.Entities.BUS;
using Infrastructure.Library.BaseService;
using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Library.Models.Views.BUS;

namespace Infrastructure.Library.Repositories.BUS
{
    public abstract class BankRepository : GenericRepository<Bank, BankDTO, BankView>, IGenericQueries
    {
        protected BankRepository(IMapper mapper) : base(mapper)
        {
        }

        public string GetCount()
        {
            throw new NotImplementedException();
        }

        public string Search(string value)
        {
            throw new NotImplementedException();
        }

        public string ShowAll(string paging)
        {
            throw new NotImplementedException();
        }

        public string ShowFromTo(string from, string to)
        {
            throw new NotImplementedException();
        }
    }
}
