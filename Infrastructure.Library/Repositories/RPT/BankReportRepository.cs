using Account.Domain.Library.Entities.RPT;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.BaseService;
using Account.Infrastructure.Library.Models.Controls;
using Account.Infrastructure.Library.Models.DTOs.RPT;
using Account.Infrastructure.Library.Models.Views.RPT;
using Account.Infrastructure.Library.Patterns;

namespace Account.Infrastructure.Library.Repositories.RPT
{
    public abstract class BankReportRepository : GenericRepository<BankReport, BankReportDTO, BankReportView>, IGenericQueries
    {
        protected BankReportRepository(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
        protected BankReportRepository(ContextDbApplication context) : base(context) { }

        public string GetCount()
        {
            return (@"");
        }

        public string Search(string value)
        {
            return (@"");
        }

        public string ShowAll(string paging)
        {
            return (@"");
        }

        public string ShowFromTo(string from, string to)
        {
            return (@"");
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
