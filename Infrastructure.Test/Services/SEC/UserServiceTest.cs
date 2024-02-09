using Infrastructure.Library.Models.DTOs.SEC;
using Infrastructure.Test.Repositories.SEC;

namespace Infrastructure.Test.Services.SEC
{
    public class UserServiceTest : IUserTestRepository
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
        public List<UserDTO> DataBase { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IEnumerable<UserDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserDTO GetById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
