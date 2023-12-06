using Domain.Library.Entities.SEC;
using Infrastructure.Library.BaseService;
using Infrastructure.Library.Models.DTOs.SEC;
using Infrastructure.Library.Models.Views.SEC;

namespace Infrastructure.Library.Repositories.SEC
{
    public abstract class GroupRepository : GenericRepository<Group, GroupDTO, GroupView>
    {

    }
}
