using AutoMapper;
using Domain.Library.Entities.BUS;
using Infrastructure.Library.BaseService;
using Infrastructure.Library.Models.Controls;
using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Library.Models.Views.BUS;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Library.Repositories.BUS
{
    public abstract class BlanceRepository : GenericRepository<Blance, BlanceDTO, BlanceView>, IGenericQueries
    {
        protected BlanceRepository(IMapper mapper) : base(mapper)
        {
        }

        public string GetCount()
        {
            throw new NotImplementedException();
        }
        public string GetBlance(long Id)
        {
            var blance = _context.Blances
                .Include(c => c.Transaction)
                .ThenInclude(x => x.Cart)
                .Where(x => x.Transaction.Cart.ID == Id).OrderByDescending(x => x.ID).FirstOrDefault();
            return blance != null ? blance.BlanceCash.ToString("N") : "";
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
            return new List<KeyValue<long>>()
            {
                new KeyValue<long> { Value = 1 ,Key = "نقدی"},
                new KeyValue<long> { Value = 2 ,Key = "بانکی"},
            };
        }
    }
}
