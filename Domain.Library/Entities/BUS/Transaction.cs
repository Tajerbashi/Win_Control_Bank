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



        public virtual Blance Blance { get; set; }
        public virtual List<TransactionReport> TransactionReports { get; set; }

    }

}
