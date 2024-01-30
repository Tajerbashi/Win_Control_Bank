using Domain.Library.Entities.HSR;
using Infrastructure.Library.ApplicationContext.EF;
using Infrastructure.Library.BaseService;
using Infrastructure.Library.Models.Controls;
using Infrastructure.Library.Models.DTOs.HSR;
using Infrastructure.Library.Models.Views.HSR;
using Infrastructure.Library.Patterns;

namespace Infrastructure.Library.Repositories.HSR
{
    public abstract class CartHistoryRepository : GenericRepository<CartHistory, CartHistoryDTO, CartHistoryView>, IGenericQueries
    {
        protected CartHistoryRepository(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
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
            throw new NotImplementedException();
        }
    }
}
