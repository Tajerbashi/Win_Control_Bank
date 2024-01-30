using Domain.Library.Enums;
using Infrastructure.Library.ApplicationContext.EF;
using Infrastructure.Library.Patterns;
using Infrastructure.Library.Repositories.BUS;

namespace Infrastructure.Library.Services.BUS
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
    }
}
