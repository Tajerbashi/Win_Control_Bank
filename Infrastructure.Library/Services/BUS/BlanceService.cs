using Domain.Library.Enums;
using Infrastructure.Library.ApplicationContext.DatabaseContext;
using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Library.Patterns;
using Infrastructure.Library.Repositories.BUS;

namespace Infrastructure.Library.Services.BUS
{
    public class BlanceService : BlanceRepository
    {
        public BlanceService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
