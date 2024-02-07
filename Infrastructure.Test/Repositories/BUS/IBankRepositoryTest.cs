using Infrastructure.Library.Models.DTOs.BUS;

namespace Infrastructure.Test.Repositories.BUS
{
    public interface IBankRepositoryTest
    {
        BankDTO GetModel(long Id);
        bool CreateModel(BankDTO bank);
        bool UpdateModel(BankDTO bank);
        bool DuplicateModel(BankDTO bank);
    }
}
