using Domain.Library.Enums;
using Infrastructure.Library.BaseModels;

namespace Infrastructure.Library.Models.DTOs.BUS
{
    public class BlanceDTO : BaseDTO
    {
        /// <summary>
        /// مبلغ موجودی
        /// </summary>
        public double BlanceCash { get; set; }
        /// <summary>
        /// نوع موجودی
        /// </summary>
        public BlanceType BlanceType { get; set; }
        /// <summary>
        /// نوع تراکنش
        /// </summary>
        public TransactionType TransactionType { get; set; }
        /// <summary>
        /// مبلغ تراکنش
        /// </summary>
        public double TransactionBlance { get; set; }
        /// <summary>
        /// کارت آیدی
        /// </summary>
        public long CartID { get; set; }

    }
}
