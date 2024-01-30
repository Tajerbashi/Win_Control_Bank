using Infrastructure.Library.ApplicationContext.EF;
using Infrastructure.Library.Patterns;
using Infrastructure.Library.Repositories.HSR;

namespace Infrastructure.Library.Services.HSR
{
    public class CartHistoryService : CartHistoryRepository
    {
        public CartHistoryService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
