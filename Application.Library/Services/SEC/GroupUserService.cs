using AutoMapper;
using Infrastructure.Library.Repositories.SEC;

namespace Infrastructure.Library.Services.SEC
{
    public class GroupUserService : GroupUserRepository
    {
        public GroupUserService(IMapper mapper) : base(mapper)
        {
        }
    }

}
