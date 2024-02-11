using Dapper;
using Account.Domain.Library.Enums;
using Account.Application.Library.ApplicationContext.DatabaseContext;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Patterns;
using Account.Application.Library.Repositories.BUS;

namespace Account.Application.Library.Services.BUS
{
    public class CartService : CartRepository
    {
        public CartService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
        public bool ValidBankBlance(long id, double cash)
        {
            var entity = Context.Blances.Where(x => x.CartID == id && !x.IsDeleted && x.BlanceType == BlanceType.Banking).OrderByDescending(x => x.ID).FirstOrDefault();
            if (entity.NewBlanceCash > cash)
                return true;
            else
                return false;
        }

        public CartDTO GetCartByAccountNumber(string accountNumber)
        {
            var result  = base.DapperServices.QueryFirstOrDefault<CartDTO>(@"
SELECT *
FROM BUS.Carts C
WHERE C.AccountNumber LIKE @AccountNumber
AND C.IsDeleted = 0
AND C.IsActive = 1
", new
            {
                AccountNumber = accountNumber,
            });
            //base.Search(name);
            return result;
        }
    }
}
