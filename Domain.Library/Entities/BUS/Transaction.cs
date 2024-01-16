using Domain.Library.Bases;
using Domain.Library.Entities.RPT;
using Domain.Library.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.BUS
{
    [Table("Transactions", Schema = "BUS")]
    public class Transaction : BaseEntity
    {
        [Description("مبلغ تراکنش")]
        public double Cash { get; set; }

        [Description("نوع تراکنش")]
        public TransactionType TransactionType { get; set; }

        [Description("کارت")]
        [ForeignKey("Cart")]
        public long CartID { get; set; }
        public Cart Cart { get; set; }

        public virtual ICollection<TransactionReport> TransactionReports { get; set; }
        public virtual ICollection<CartHistory> CartHistories { get; set; }

    }

}
