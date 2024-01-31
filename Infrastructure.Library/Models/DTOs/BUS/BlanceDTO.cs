using Domain.Library.Enums;
using Infrastructure.Library.BaseModels;

namespace Infrastructure.Library.Models.DTOs.BUS
{
    public class BlanceDTO : BaseDTO
    {
        /// <summary>
        /// مبلغ موجودی قبلی
        /// </summary>
        public double OldBlanceCash { get; set; }
        /// <summary>
        /// مبلغ موجودی جدید
        /// </summary>
        public double NewBlanceCash { get; set; }
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
        public double TransactionCash { get; set; }
        /// <summary>
        /// کارت آیدی
        /// </summary>
        public long CartID { get; set; }
        /// <summary>
        /// کلید تراکنش
        /// </summary>
        public Guid TransactionId { get; set; }


    }
}
