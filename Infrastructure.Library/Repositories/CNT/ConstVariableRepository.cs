using Account.Domain.Library.Entities.CNT;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.BaseService;
using Account.Infrastructure.Library.Models.Controls;
using Account.Infrastructure.Library.Models.DTOs.CNT;
using Account.Infrastructure.Library.Models.Views.CNT;
using Account.Infrastructure.Library.Patterns;

namespace Account.Infrastructure.Library.Repositories.CNT
{
    public abstract class ConstVariableRepository : GenericRepository<ConstVariable, ConstVariableDTO, ConstVariableView>, IGenericQueries
    {
        protected ConstVariableRepository(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
        protected ConstVariableRepository(ContextDbApplication context) : base(context) { }

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
