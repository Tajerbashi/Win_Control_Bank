using Account.Domain.Library.Entities.WEB;
using Account.Application.Library.ApplicationContext.DatabaseContext;
using Account.Application.Library.BaseService;
using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.WEB;
using Account.Application.Library.Models.Views.WEB;
using Account.Application.Library.Patterns;

namespace Account.Application.Library.Repositories.WEB
{
    public abstract class WebServiceRepository : GenericRepository<WebService, WebServiceDTO, WebServiceView>, IBaseQueries
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
