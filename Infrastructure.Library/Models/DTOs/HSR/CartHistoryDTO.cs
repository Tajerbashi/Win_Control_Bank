using Domain.Library.Enums;
using Infrastructure.Library.BaseModels;
using System.ComponentModel;

namespace Infrastructure.Library.Models.DTOs.HSR
{
    public class CartHistoryDTO : BaseDTO
    {
        public TransactionType TransactionType { get; set; }
        public BlanceType BlanceType { get; set; }
        public double CashBlance { get; set; }
        public double CashTransaction { get; set; }
        public string Message { get; set; }
        public long BlanceID { get; set; }
        public long FromCartID { get; set; }
        public long ToCartID { get; set; }
        public long CartID { get; set; }
    }
}
