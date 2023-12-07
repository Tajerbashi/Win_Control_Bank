using AutoMapper;
using Infrastructure.Library.Repositories.SEC;

namespace Infrastructure.Library.Services.SEC
{
    public class GroupService : GroupRepository
    {
        public GroupService(IMapper mapper) : base(mapper)
        {
        }
    }

}
