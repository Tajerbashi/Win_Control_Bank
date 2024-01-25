using Domain.Library.Bases;
using Domain.Library.Entities.LOG;
using Domain.Library.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.BUS
{
    [Table("Blances", Schema = "BUS")]
    public class Blance : BaseEntity
    {
        [Description("موجودی")]
        public double BlanceCash { get; set; }

        [Description("نوع موجودی")]
        public BlanceType BlanceType { get; set; }

        [Description("مبلغ تراکنش")]
        public double CurrentBlance { get; set; }

        [Description("نوع تراکنش")]
        public TransactionType TransactionType { get; set; }

        [Description("کارت")]
        [ForeignKey("Cart")]
        public long CartID { get; set; }
        public virtual Cart Cart { get; set; }


    }
}
