using Account.Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Test.BaseTests;
using Infrastructure.Test.Models;
using Infrastructure.Test.Repositories.BUS;

namespace Infrastructure.Test.Services.BUS
{
    public class BankTestService : IBankTestRepository
    {
        public BankTestService()
        {
            this.DataBase = this.GetAll().ToList();
        }

        public List<BankDTO> DataBase { get; set ; }

        public ResultTest<bool> Create_InsertBankData_Model(BankDTO bankDTO)
        {
            return Duplicate_AddOrUpdateBankData_Model(bankDTO);
        }

        public ResultTest<bool> Duplicate_AddOrUpdateBankData_Model(BankDTO bankDTO)
        {
            var model = DataBase.Where(x => x.ID == bankDTO.ID).FirstOrDefault();
            if (model is null)
            {
                DataBase.Add(bankDTO);
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

        public IEnumerable<BankDTO> GetAll()
        {
            var result = new List<BankDTO>();

            for (int i = 0; i < 10; i++)
            {
                result.Add(new BankDTO
                {
                    ID = i,
                    BankName = $"Bank Name-{i}",
                });
            }

            return result;
        }

        public BankDTO GetById(long id)
        {
            return DataBase.Where(x => x.ID == id).Single();
        }

        public ResultTest<bool> Update_UpdateBankData_Model(BankDTO bankDTO)
        {
            var model = this.GetById(bankDTO.ID);
            DataBase.Remove(model);
            model = bankDTO;
            DataBase.Add(model);
            return new ResultTest<bool>
            {
                Result = true,
                Message = MessagesResponse.Success("اطلاعات ویرایش شده است"),
            };
        }
    }
}
