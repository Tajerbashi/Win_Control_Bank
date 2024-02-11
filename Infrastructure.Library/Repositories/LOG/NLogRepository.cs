using AutoMapper;
using Account.Domain.Library.Entities.LOG;
using Account.Application.Library.ApplicationContext.DatabaseContext;
using Account.Application.Library.BaseService;
using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.LOG;
using Account.Application.Library.Models.Views.LOG;
using Account.Application.Library.Patterns;

namespace Account.Application.Library.Repositories.LOG
{
    public abstract class NLogRepository : GenericRepository<NLog, NLogDTO, NLogView>, IBaseQueries
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
