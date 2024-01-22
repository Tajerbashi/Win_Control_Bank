using Domain.Library.Entities.BUS;
using Infrastructure.Library.ApplicationContext.EF;
using Infrastructure.Library.BaseService;
using Infrastructure.Library.Models.Controls;
using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Library.Models.Views.BUS;
using Infrastructure.Library.Patterns;

namespace Infrastructure.Library.Repositories.BUS
{
    public abstract class CartHistoryRepository : GenericRepository<CartHistory, CartHistoryDTO, CartHistoryView>, IGenericQueries
    {
        protected CartHistoryRepository(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
        protected CartHistoryRepository(ContextDbApplication context)
           : base(context)
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

        public IEnumerable<KeyValue<long>> TitleValue()
        {
            return Context.Banks.Select(x => new KeyValue<long>
            {
                Key = x.BankName,
                Value = x.ID
            });
        }
    }
}
