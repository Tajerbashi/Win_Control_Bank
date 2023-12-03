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
        public double Cash { get; set; }

        [Description("نوع تراکنش")]
        public TransactionType TransactionType { get; set; }


        public virtual List<CartTransaction> CartTransactions { get; set; }
        public virtual List<TransactionReport> TransactionReports { get; set; }

    }

    [Table("CartTransactions", Schema = "BUS")]
    public class CartTransaction : BaseEntity
    {

        [ForeignKey("Cart")]
        public long CartID { get; set; }
        public virtual Cart Cart { get; set; }

        [ForeignKey("Transaction")]
        public long TransactionID { get; set; }
        public virtual Transaction Transaction { get; set; }
    }

}
