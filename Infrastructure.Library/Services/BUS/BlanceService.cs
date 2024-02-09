using Infrastructure.Library.ApplicationContext.DatabaseContext;
using Infrastructure.Library.Patterns;
using Infrastructure.Library.Repositories.BUS;

namespace Infrastructure.Library.Services.BUS
{
    public class BlanceService : BlanceRepository
    {
        //private UnitOfWork<EmployeeDBContext> unitOfWork = new UnitOfWork<EmployeeDBContext>();
        //private GenericRepository<Employee> genericRepository;
        //private IEmployeeRepository employeeRepository;
        //public EmployeeController()
        //{
        //    //If you want to use Generic Repository with Unit of work
        //    genericRepository = new GenericRepository<Employee>(unitOfWork);
        //    //If you want to use a Specific Repository with Unit of work
        //    employeeRepository = new EmployeeRepository(unitOfWork);
        //}
        public BlanceService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
        public void DisActiveLastBlanceOfCartById(long Id)
        {
            var model = Context.Blances.Where(x => x.CartID == Id).OrderByDescending(x => x.ID).FirstOrDefault();
            if (model is not null)
            {
                model.IsActive = false;
            }
            Context.Blances.Update(model);
            Context.SaveChanges();
        }
    }
}
