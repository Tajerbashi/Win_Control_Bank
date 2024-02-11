using Account.Application.Library.BaseService;
using Account.Application.Library.Models.Controls;
using Account.Domain.Library.Entities.BUS;

namespace Account.Application.Library.Repositories.BUS
{
    public abstract class BankRepository : IBankRepository, IBaseQueries
    {
        public void Active(Guid guid)
        {
            throw new NotImplementedException();
        }

        public long AddOrUpdate(Bank obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid guid)
        {
            throw new NotImplementedException();
        }

        public void DisActive(Guid guid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Bank> GetAll()
        {
            throw new NotImplementedException();
        }

        public Bank GetById(object id)
        {
            throw new NotImplementedException();
        }

        public string GetCount()
        {
            throw new NotImplementedException();
        }

        public long Insert(Bank obj)
        {
            throw new NotImplementedException();
        }

        public object Save()
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

        public void Update(Bank obj)
        {
            throw new NotImplementedException();
        }
    }
}
