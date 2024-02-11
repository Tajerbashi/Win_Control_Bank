using Account.Application.Library.BaseService;
using Account.Application.Library.Models.DTOs.CNT;
using Account.Application.Library.Models.Views.CNT;
using Account.Domain.Library.Entities.CNT;

namespace Account.Application.Library.Repositories.CNT
{
    public interface IConstVariableRepository : IGenericRepository<ConstVariable, ConstVariableDTO, ConstVariableView>, IBaseQueries
    {
    }
}
