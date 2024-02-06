using Domain.Library.Entities.RPT;
using Infrastructure.Library.ApplicationContext.DatabaseContext;
using Infrastructure.Library.BaseService;
using Infrastructure.Library.Models.Controls;
using Infrastructure.Library.Models.DTOs.RPT;
using Infrastructure.Library.Models.Views.RPT;
using Infrastructure.Library.Patterns;

namespace Infrastructure.Library.Repositories.RPT
{
    public abstract class CartReportRepository : GenericRepository<CartReport, CartReportDTO, CartReportView>, IGenericQueries
    {
        protected CartReportRepository(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
        protected CartReportRepository(ContextDbApplication context) : base(context) { }

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
            return Context.Banks.Select(x => new KeyValue<long>
            {
                Key = x.BankName,
                Value = x.ID
            });
        }
    }
}
