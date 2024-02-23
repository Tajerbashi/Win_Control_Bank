using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Models.Views.BUS;
using Account.Application.Library.Repositories.BUS;
using Account.Domain.Library.Entities.BUS;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.BaseService;
using Account.Infrastructure.Library.Repositories.BUS.Queries;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace Account.Infrastructure.Library.Repositories.BUS
{
    public class BankRepository : GenericRepository<Bank, BankDTO, BankView>, IBankRepository
    {
        public BankRepository(ContextDbApplication context, IMapper mapper) : base(context, mapper)
        {
        }
        public IEnumerable<KeyValue<long>> BankTitleValue()
        {
            return Context.Banks.Where(x => !x.IsDeleted && !x.BankName.Contains(":")).Select(x => new KeyValue<long>
            {
                Key = x.BankName,
                Value = x.ID
            }).OrderByDescending(x => x.Key);
        }
        public BankDTO GetBankByName(string name)
        {
            var result = Context.Banks.Where(c => c.BankName.Equals(name.Trim())).FirstOrDefault();
            return Mapper.Map<Bank, BankDTO>(result);
        }

        public string GetCount()
        {
            return BankQueries.GetCount();
        }

        public string Search(string value)
        {
            return null;
        }

        public string ShowAll(string paging)
        {
            return BankQueries.ShowAll(paging);
        }

        public string ShowFromTo(string from, string to)
        {
            return null;
        }

        public IEnumerable<KeyValue<byte>> TitleValue()
        {
            return null;
        }
    }
}
