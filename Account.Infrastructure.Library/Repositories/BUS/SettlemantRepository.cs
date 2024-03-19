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

namespace Account.Infrastructure.Library.Repositories.BUS
{
    public class SettlemantRepository : GenericRepository<Settlemant, SettlemantDTO, SettlemantView>, ISettlemantRepository
    {
        public SettlemantRepository(ContextDbApplication context, IMapper mapper) : base(context, mapper)
        {
        }

        public string GetCount()
        {
            return SettlemantQueries.GetCount();
        }

        public string Search(string value)
        {
            return SettlemantQueries.Search(value);
        }

        public string ShowAll(string paging)
        {
            return SettlemantQueries.ShowAll(paging);
        }

        public string ShowFromTo(string from, string to)
        {
            return SettlemantQueries.ShowFromTo(from,to);
        }

        public IEnumerable<KeyValue<byte>> TitleValue()
        {
            return SettlemantQueries.TitleValue();
        } 
        public string GetSumOfSettlemant(long ID)
        {
            return SettlemantQueries.GetSumOfSettlemant(ID);
        }
    }
}
