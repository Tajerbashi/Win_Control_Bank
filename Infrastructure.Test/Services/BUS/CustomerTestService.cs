using Account.Application.Library.Models.DTOs.BUS;
using Infrastructure.Test.Events.BUS;
using Infrastructure.Test.Exceptions;
using Infrastructure.Test.Models;
using Infrastructure.Test.Repositories.BUS;

namespace Infrastructure.Test.Services.BUS
{
    public class CustomerTestService : ICustomerTestRepository
    {
        public event EventHandler<CustomerStatusEventArgs>? StatusChanged;
        public List<CustomerDTO> DataBase { get; set; }
        public CustomerTestService()
        {
            DataBase = new List<CustomerDTO>();
            DataBase = this.GetAll().ToList();
        }
        public ResultTest<bool> Check_DuplicateCustomer_Model(CustomerDTO customer)
        {
            var result = DataBase.Where(x => x.ID == customer.ID || x.FullName.Equals(customer.FullName) ).FirstOrDefault();
            if (result is null)
            {
                DataBase.Add(customer);
                return new ResultTest<bool>
                {
                    Result = true,
                    Message = MessagesResponse.Success(),
                };
            }
            return new ResultTest<bool>
            {
                Result = false,
                Message = MessagesResponse.Duplicate(),
            };
        }

        public ResultTest<bool> Create_NewCustomer_Model(CustomerDTO customer)
        {
            return Check_DuplicateCustomer_Model(customer);
        }

        public IEnumerable<CustomerDTO> GetAll()
        {
            for (int i = 0; i < 10; i++)
            {
                DataBase.Add(new CustomerDTO
                {
                    ID = i,
                    FullName = $"Customer FullName-{i}",
                    Key = Guid.NewGuid(),
                    Picture = "",
                });
            }
            return DataBase;
        }

        public CustomerDTO GetById(long id)
        {
            return DataBase.Where(x => x.ID == id).Single();
        }

        public ResultTest<bool> Update_CustomerNewData_Model(CustomerDTO customer)
        {
            var model = DataBase.Where(x => x.ID == customer.ID).Single();
            DataBase.Remove(model);
            DataBase.Add(model);
            return new ResultTest<bool>
            {
                Result = true,
                Message = MessagesResponse.Success(),
            };
        }

        public ResultTest<bool> FindData_CustomerGetById_Entity(long id)
        {
            if (id == 0)
            {
                throw new InvalidModelException("کلید درست نیست", 0);
            }
            return new ResultTest<bool>
            {
                Message = MessagesResponse.Success(),
                Result = DataBase.Any(x => x.ID == id)
            };
        }

        public void NotifyOfCustomerStatus(CustomerDTO customer)
        {
            OnStatusCallingLastResult(new CustomerStatusEventArgs(customer.Key));
        }

        protected virtual void OnStatusCallingLastResult
            (CustomerStatusEventArgs eventArgs)
        {
            StatusChanged?.Invoke(this,eventArgs);
        }
    }
}
