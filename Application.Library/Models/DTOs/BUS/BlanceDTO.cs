using Domain.Library.Entities.LOG;
using Infrastructure.Library.BaseModels;

namespace Infrastructure.Library.Models.DTOs.BUS
{
    public class BlanceDTO : BaseDTO
    {
        public double LastCash { get; set; }
        public double Cash { get; set; }
        public long CartID { get; set; }
        public List<BlanceLog> BlanceLogs { get; set; }
    }
}
