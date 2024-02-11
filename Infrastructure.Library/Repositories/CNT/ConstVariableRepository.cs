using Account.Domain.Library.Entities.CNT;
using Account.Application.Library.ApplicationContext.DatabaseContext;
using Account.Application.Library.BaseService;
using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.CNT;
using Account.Application.Library.Models.Views.CNT;
using Account.Application.Library.Patterns;

namespace Account.Application.Library.Repositories.CNT
{
    public abstract class ConstVariableRepository : GenericRepository<ConstVariable, ConstVariableDTO, ConstVariableView>, IBaseQueries
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
