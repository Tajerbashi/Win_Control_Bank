using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.LOG;
using Account.Application.Library.Models.Views.LOG;
using Account.Domain.Library.Entities.LOG;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.BaseService;
using AutoMapper;
using System;
using System.Collections.Generic;

namespace Account.Application.Library.Repositories.LOG
{
    public class NLogRepository : GenericRepository<NLog, NLogDTO, NLogView>, INLogRepository
    {
        public NLogRepository(ContextDbApplication context, IMapper mapper) : base(context, mapper)
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
