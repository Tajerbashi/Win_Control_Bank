using AutoMapper;
using Infrastructure.Library.Repositories.SEC;

namespace Infrastructure.Library.Services.SEC
{
    public class UserService : UserRepository
    {
        public UserService(IMapper mapper) : base(mapper)
        {
        }
    }

}
