using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.RPT;
using Account.Application.Library.Models.Views.RPT;
using Account.Domain.Library.Entities.RPT;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.BaseService;
using Account.Infrastructure.Library.Patterns;
using System.Collections.Generic;
using System.Linq;

namespace Account.Application.Library.Repositories.RPT
{
    public class BankReportRepository : GenericRepository<BankReport, BankReportDTO, BankReportView>, IBankReportRepository
    {
        public BankReportRepository(UnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
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
