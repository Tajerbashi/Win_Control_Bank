using Account.Domain.Library.Entities.WEB;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.BaseService;
using Account.Infrastructure.Library.Models.Controls;
using Account.Infrastructure.Library.Models.DTOs.WEB;
using Account.Infrastructure.Library.Models.Views.WEB;
using Account.Infrastructure.Library.Patterns;

namespace Account.Infrastructure.Library.Repositories.WEB
{
    public abstract class WebServiceRepository : GenericRepository<WebService, WebServiceDTO, WebServiceView>, IGenericQueries
    {
        private readonly UnitOfWork<ContextDbApplication> unitOfWork = new UnitOfWork<ContextDbApplication>();
        //private GenericRepository<Employee> genericRepository;
        //private IEmployeeRepository employeeRepository;
        protected WebServiceRepository(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
            //genericRepository = new GenericRepository<Employee>(unitOfWork);
            //employeeRepository = new EmployeeRepository(unitOfWork);
        }
        protected WebServiceRepository(ContextDbApplication context) : base(context) { }

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
