using AutoMapper;
using Infrastructure.Library.Repositories.SEC;

namespace Infrastructure.Library.Services.SEC
{
    public class UserRoleService : UserRoleRepository
    {
        public UserRoleService(IMapper mapper) : base(mapper)
        {
        }
    }

}
