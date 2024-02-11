using Account.Application.Library.BaseService;
using Account.Application.Library.Models.DTOs.LOG;
using Account.Application.Library.Models.Views.LOG;
using Account.Domain.Library.Entities.LOG;

namespace Account.Application.Library.Repositories.LOG
{
    public interface INLogRepository : IGenericRepository<NLog, NLogDTO, NLogView>, IBaseQueries
    {
    }
}
