using AutoMapper;
using Infrastructure.Library.Repositories.SEC;

namespace Infrastructure.Library.Services.SEC
{
    public class RoleService : RoleRepository
    {
        public RoleService(IMapper mapper) : base(mapper)
        {
        }
    }

}
