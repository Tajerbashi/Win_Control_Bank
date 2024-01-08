using AutoMapper;
using Domain.Library.Entities.SEC;
using Domain.Library.Entities.WEB;
using Infrastructure.Library.BaseService;
using Infrastructure.Library.Models.Controls;
using Infrastructure.Library.Models.DTOs.SEC;
using Infrastructure.Library.Models.DTOs.WEB;
using Infrastructure.Library.Models.Views.SEC;
using Infrastructure.Library.Models.Views.WEB;

namespace Infrastructure.Library.Repositories.WEB
{
    public abstract class WebServiceRepository : GenericRepository<WebService, WebServiceDTO, WebServiceView>, IGenericQueries
    {
        protected WebServiceRepository(IMapper mapper) : base(mapper)
        {
        }

        public string GetCount()
        {
            throw new NotImplementedException();
        }

        public string Search(string value)
        {
            throw new NotImplementedException();
        }

        public string ShowAll(string paging)
        {
            throw new NotImplementedException();
        }

        public string ShowFromTo(string from, string to)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<KeyValue<long>> TitleValue()
        {
            throw new NotImplementedException();
        }
    }
}
