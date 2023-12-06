using Domain.Library.Entities.SEC;
using Infrastructure.Library.BaseService;
using Infrastructure.Library.Models.DTOs.SEC;
using Infrastructure.Library.Models.Views.SEC;

namespace Infrastructure.Library.Repositories.SEC
{
    public abstract class UserRoleGroupRepository : GenericRepository<UserRoleGroup, UserRoleGroupDTO, UserRoleGroupView>, IGenericQueries
    {
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
    }
}
