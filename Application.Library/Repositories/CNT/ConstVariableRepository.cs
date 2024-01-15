using Domain.Library.Entities.CNT;
using Infrastructure.Library.ApplicationContext.EF;
using Infrastructure.Library.BaseService;
using Infrastructure.Library.Models.Controls;
using Infrastructure.Library.Models.DTOs.CNT;
using Infrastructure.Library.Models.Views.CNT;
using Infrastructure.Library.Patterns;

namespace Infrastructure.Library.Repositories.CNT
{
    public abstract class ConstVariableRepository : GenericRepository<ConstVariable, ConstVariableDTO, ConstVariableView>, IGenericQueries
    {
        protected ConstVariableRepository(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
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
