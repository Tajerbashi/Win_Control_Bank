using AutoMapper;
using Domain.Library.Entities.BUS;
using Domain.Library.Enums;
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
        protected BlanceRepository(ContextDbApplication context)
            : base(context)
        {
        }

        public string GetCount()
        {
            throw new NotImplementedException();
        }
        public double GetBlanceCartById(long Id)
        {
            var result = Context.Blances.Where(x => x.CartID == Id && x.BlanceType == BlanceType.Banking).Single().BlanceCash;
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
        public string ShowAllByCartId(long Id, string paging)
        {
            throw new NotImplementedException();
        }
         public string Show50LastTransactions(string paging)
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
