using AutoMapper;
using Domain.Library.Entities.BUS;
using Infrastructure.Library.BaseService;
using Infrastructure.Library.Models.Controls;
using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Library.Models.Views.BUS;

namespace Infrastructure.Library.Repositories.BUS
{
    public abstract class TransactionRepository : GenericRepository<Transaction, TransactionDTO, TransactionView>, IGenericQueries
    {
        protected TransactionRepository(IMapper mapper) : base(mapper)
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
            List<KeyValue<long>> result = new List<KeyValue<long>>()
            {
                new KeyValue<long> { Value = 1 ,Key = "خرید از کارت"},
                new KeyValue<long> { Value = 2 ,Key = "برداشت نقدی"},
                new KeyValue<long> { Value = 3 ,Key = "انتقال به کارت دیگر"},
                new KeyValue<long> { Value = 4 ,Key = "واریز به کارت"},
            };

            return result;
        }
    }
}
