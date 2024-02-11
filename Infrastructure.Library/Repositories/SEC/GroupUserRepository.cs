using AutoMapper;
using Account.Domain.Library.Entities.SEC;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.BaseService;
using Account.Infrastructure.Library.Models.Controls;
using Account.Infrastructure.Library.Models.DTOs.SEC;
using Account.Infrastructure.Library.Models.Views.SEC;
using Account.Infrastructure.Library.Patterns;

namespace Account.Infrastructure.Library.Repositories.SEC
{
    public abstract class GroupUserRepository : GenericRepository<GroupUser, GroupUserDTO, GroupUserView>, IGenericQueries
    {
        protected GroupUserRepository(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
        protected GroupUserRepository(ContextDbApplication context) : base(context) { }

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
            return Context.Banks.Select(x => new KeyValue<long>
            {
                Key = x.BankName,
                Value = x.ID
            });
        }
    }
}
