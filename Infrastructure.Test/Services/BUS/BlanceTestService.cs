using Account.Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Test.Repositories.BUS;

namespace Infrastructure.Test.Services.BUS
{
    public class BlanceTestService : IBlanceTestRepository
    {
        public List<BlanceDTO> DataBase { get; set; }

        public IEnumerable<BlanceDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public BlanceDTO GetById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
