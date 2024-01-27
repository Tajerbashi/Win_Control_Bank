using Dapper;
using Infrastructure.Library.ApplicationContext.EF;
using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Library.Patterns;
using Infrastructure.Library.Repositories.BUS;

namespace Infrastructure.Library.Services.BUS
{
    public class BankService : BankRepository
    {

        public BankService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
        public (List<BankDTO>, List<CartDTO>) GetData()
        {
            try
            {
                var banks = new List<BankDTO>();
                var carts = new List<CartDTO>();
                var bankData = base.DapperServices.Query<BankDTO>("SELECT * FROM BUS.Banks",new
                {

                });
                var CartData = base.DapperServices.Query<CartDTO>("SELECT * FROM BUS.Carts",new
                {

                });
                banks.AddRange(bankData);
                carts.AddRange(CartData);
                return (banks, carts);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
