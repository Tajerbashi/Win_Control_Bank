using Domain.Library.Enums;
using Infrastructure.Library.BaseModels;

namespace Infrastructure.Library.Models.DTOs.BUS
{
    public class TransactionDTO : BaseDTO
    {
        public long CartID { get; set; }
        public double Cash { get; set; }
        public TransactionType TransactionType { get; set; }
    }
}
