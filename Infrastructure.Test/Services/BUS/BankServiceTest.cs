using Domain.Library.Entities.BUS;
using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Test.Repositories.BUS;

namespace Infrastructure.Test.Services.BUS
{
    public class BankServiceTest : IBankRepositoryTest
    {
        private readonly IList<Bank> banks; 
        public BankServiceTest()
        {
            banks = new List<Bank>();
        }
        public bool CreateModel(BankDTO bank)
        {
            if (bank.ID == 0)
                return true;
            return false;
        }

        public bool DuplicateModel(BankDTO bank)
        {
            var res = from s in banks
                      where bank.BankName == s.BankName
                      select s;
            if (res == null)
                return true;
            return false;
        }

        public BankDTO GetModel(long Id)
        {
            return new BankDTO
            {
                ID = Id,
                BankName = "Name",
                Title = "Title",
                Description = "Description",
                
            };
        }

        public bool UpdateModel(BankDTO bank)
        {
            if (bank.ID == 0)
                return false;
            return true;
        }
    }
}
