using Account.Application.Library.BaseService;
using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.WEB;
using Account.Application.Library.Models.Views.WEB;
using Account.Domain.Library.Entities.WEB;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.BaseService;
using AutoMapper;
using System;
using System.Collections.Generic;

namespace Account.Application.Library.Repositories.WEB
{
    public abstract class WebServiceRepository : GenericRepository<WebService, WebServiceDTO, WebServiceView>, IBaseQueries
    {
        protected WebServiceRepository(ContextDbApplication context, IMapper mapper) : base(context, mapper)
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

        public IEnumerable<KeyValue<byte>> TitleValue()
        {
            throw new NotImplementedException();
        }
    }
}
