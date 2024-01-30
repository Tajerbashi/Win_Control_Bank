using Domain.Library.Bases;
using Domain.Library.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.BUS
{
    [Table("Blances", Schema = "BUS")]
    public class Blance : BaseEntity
    {
        [Description("موجودی جدید")]
        public double NewBlanceCash { get; set; }

        [Description("موجودی قبل")]
        public double OldBlanceCash { get; set; }

        [Description("نوع موجودی")]
        public BlanceType BlanceType { get; set; }

        [Description("مبلغ تراکنش")]
        public double TransactionCash { get; set; }

        [Description("نوع تراکنش")]
        public TransactionType TransactionType { get; set; }
        
        [Description("کلید تراکنش")]
        public Guid TransactionId { get; set; }


        [Description("کارت")]
        [ForeignKey("Cart")]
        public long CartID { get; set; }
        public virtual Cart Cart { get; set; }


    }
}
