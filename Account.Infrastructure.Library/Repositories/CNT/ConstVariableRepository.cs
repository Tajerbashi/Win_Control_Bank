using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.CNT;
using Account.Application.Library.Models.Views.CNT;
using Account.Domain.Library.Entities.CNT;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.BaseService;
using Account.Infrastructure.Library.Patterns;
using System;
using System.Collections.Generic;

namespace Account.Application.Library.Repositories.CNT
{
    public class ConstVariableRepository : GenericRepository<ConstVariable, ConstVariableDTO, ConstVariableView>, IConstVariableRepository
    {
        public ConstVariableRepository(UnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
        protected ConstVariableRepository(ContextDbApplication context) : base(context) { }

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
            throw new NotImplementedException();
        }
    }
}
