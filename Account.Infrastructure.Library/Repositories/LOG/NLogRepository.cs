using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.LOG;
using Account.Application.Library.Models.Views.LOG;
using Account.Domain.Library.Entities.LOG;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.BaseService;
using Account.Infrastructure.Library.Patterns;

namespace Account.Application.Library.Repositories.LOG
{
    public class NLogRepository : GenericRepository<NLog, NLogDTO, NLogView>, INLogRepository
    {
        public NLogRepository(UnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
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
