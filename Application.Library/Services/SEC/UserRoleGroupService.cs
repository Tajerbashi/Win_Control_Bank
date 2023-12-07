using AutoMapper;
using Infrastructure.Library.Repositories.SEC;

namespace Infrastructure.Library.Services.SEC
{
    public class UserRoleGroupService : UserRoleGroupRepository
    {
        public UserRoleGroupService(IMapper mapper) : base(mapper)
        {
        }
    }

}
