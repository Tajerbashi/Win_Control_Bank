using Domain.Library.Bases;
using Domain.Library.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.BUS
{
    [Table("CartHistories", Schema = "BUS")]
    public class CartHistory : GeneralEntity
    {
        [Description("نوع تراکنش")]
        public TransactionType TransactionType { get; set; }

        [Description("نوع موجودی")]
        public BlanceType BlanceType { get; set; }

        [Description("مبلغ")]
        public double Cash { get; set; }

        [Description("وجه نقد")]
        public bool IsCashable { get; set; }

        [Description("از کارت")]
        public Guid FromCartKey { get; set; }

        [Description("به کارت")]
        public Guid ToCartKey { get; set; }

        [Description("پیام")]
        public string Message { get; set; }

        [ForeignKey("Cart")]
        public long CartID { get; set; }
        public virtual Cart Cart { get; set; }

        [ForeignKey("Blance")]
        public long BlanceID { get; set; }
        public virtual Blance Blance { get; set; }

        [ForeignKey("Transaction")]
        public long TransactionID { get; set; }
        public virtual Transaction Transaction { get; set; }

        public override string ToString()
        {
            return ($@"");
        }
    }
}
