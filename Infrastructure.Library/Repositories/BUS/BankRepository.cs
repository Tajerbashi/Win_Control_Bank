using Account.Application.Library.ApplicationContext.DatabaseContext;
using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Models.Views.BUS;
using Account.Application.Library.Patterns;
using Account.Domain.Library.Entities.BUS;
using Account.Infrastructure.Library.BaseService;

namespace Account.Application.Library.Repositories.BUS
{
    public abstract class BankRepository : GenericRepository<Bank, BankDTO, BankView>, IBankRepository
    {
        protected BankRepository(UnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
        protected BankRepository(ContextDbApplication context) : base(context)
        {
        }

        public BankDTO GetBankByName(string name)
        {
            throw new NotImplementedException();
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
