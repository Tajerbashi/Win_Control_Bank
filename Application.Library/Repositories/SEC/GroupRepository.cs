using AutoMapper;
using Domain.Library.Entities.SEC;
using Infrastructure.Library.BaseService;
using Infrastructure.Library.Models.Controls;
using Infrastructure.Library.Models.DTOs.SEC;
using Infrastructure.Library.Models.Views.SEC;

namespace Infrastructure.Library.Repositories.SEC
{
    public abstract class GroupRepository : GenericRepository<Group, GroupDTO, GroupView>, IGenericQueries
    {
        protected GroupRepository(IMapper mapper) : base(mapper)
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

        public IEnumerable<KeyValue<long>> TitleValue()
        {
            return _context.Banks.Select(x => new KeyValue<long>
            {
                Key = x.BankName,
                Value = x.ID
            });
        }
    }
}
