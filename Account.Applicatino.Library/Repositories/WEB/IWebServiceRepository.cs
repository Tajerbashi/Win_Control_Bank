using Account.Application.Library.BaseService;
using Account.Application.Library.Models.DTOs.WEB;
using Account.Application.Library.Models.Views.WEB;
using Account.Domain.Library.Entities.WEB;

namespace Account.Application.Library.Repositories.WEB
{
    public interface IWebServiceRepository : IGenericRepository<WebService, WebServiceDTO, WebServiceView>, IBaseQueries
    {
    
    }
}
