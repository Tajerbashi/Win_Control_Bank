using Domain.Library.Enums;
using Infrastructure.Library.BaseModels;

namespace Infrastructure.Library.Models.DTOs.BUS
{
    public class BlanceDTO : BaseDTO
    {
        public double BlanceCash { get; set; }

        public BlanceType BlanceType { get; set; }

        public long CartID { get; set; }
    }
}
