using Account.Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Test.BaseTests;
using Infrastructure.Test.Models;

namespace Infrastructure.Test.Repositories.BUS
{
    public interface IBankTestRepository : IBaseTestRepository<BankDTO>
    {
        ResultTest<bool> Create_InsertBankData_Model(BankDTO bankDTO);
        ResultTest<bool> Update_UpdateBankData_Model(BankDTO bankDTO);
        ResultTest<bool> Duplicate_AddOrUpdateBankData_Model(BankDTO bankDTO);
    }
}
