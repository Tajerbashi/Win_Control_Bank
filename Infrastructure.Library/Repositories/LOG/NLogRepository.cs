using AutoMapper;
using Account.Domain.Library.Entities.LOG;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.BaseService;
using Account.Infrastructure.Library.Models.Controls;
using Account.Infrastructure.Library.Models.DTOs.LOG;
using Account.Infrastructure.Library.Models.Views.LOG;
using Account.Infrastructure.Library.Patterns;

namespace Account.Infrastructure.Library.Repositories.LOG
{
    public abstract class NLogRepository : GenericRepository<NLog, NLogDTO, NLogView>, IGenericQueries
    {
        protected NLogRepository(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
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
