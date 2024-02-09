using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Test.Repositories.BUS;

namespace Infrastructure.Test.Services.BUS
{
    public class CartTestService : ICartTestRepository
    {
        public List<CartDTO> DataBase { get; set; }

        public IEnumerable<CartDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public CartDTO GetById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
