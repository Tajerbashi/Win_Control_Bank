using Account.Domain.Library.Entities.RPT;
using Account.Application.Library.ApplicationContext.DatabaseContext;
using Account.Application.Library.BaseService;
using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.RPT;
using Account.Application.Library.Models.Views.RPT;
using Account.Application.Library.Patterns;
using Account.Infrastructure.Library.BaseService;

namespace Account.Application.Library.Repositories.RPT
{
    public abstract class BankReportRepository : GenericRepository<BankReport, BankReportDTO, BankReportView>, IBankReportRepository
    {
        protected BankReportRepository(UnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
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
