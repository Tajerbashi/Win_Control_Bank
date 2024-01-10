using AutoMapper;
using Domain.Library.Entities.BUS;
using Infrastructure.Library.ApplicationContext.EF;
using Infrastructure.Library.BaseService;
using Infrastructure.Library.Models.Controls;
using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Library.Models.Views.BUS;
using Infrastructure.Library.Patterns;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Library.Repositories.BUS
{
    public abstract class BlanceRepository : GenericRepository<Blance, BlanceDTO, BlanceView>, IGenericQueries
    {
        protected BlanceRepository(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }

        public string GetCount()
        {
            throw new NotImplementedException();
        }
        public string GetBlance(long Id)
        {
            var lastBlance = Context.Transactions.Include(x => x.Blance).Where(x => x.CartID == Id).OrderByDescending(x => x.ID).FirstOrDefault().Blance.BlanceCash;
            return lastBlance != null ? lastBlance.ToString("N") : "";
        }
        public double GetBlanceCash(long Id)
        {
            var result  = Context.Transactions.Include(x => x.Blance).Where(x => x.CartID == Id).OrderByDescending(x => x.ID).FirstOrDefault().Blance.BlanceCash;
            return result;
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
