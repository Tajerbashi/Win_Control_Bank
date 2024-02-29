using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Models.Views.BUS;
using Account.Application.Library.Repositories.BUS;
using Account.Domain.Library.Entities.BUS;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.BaseService;
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
            throw new System.NotImplementedException();
        }

        public string Search(string value)
        {
            throw new System.NotImplementedException();
        }

        public string ShowAll(string paging)
        {
            throw new System.NotImplementedException();
        }

        public string ShowFromTo(string from, string to)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<KeyValue<byte>> TitleValue()
        {
            throw new System.NotImplementedException();
        }
    }
}
