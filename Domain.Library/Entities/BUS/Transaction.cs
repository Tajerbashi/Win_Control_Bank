using Domain.Library.Bases;
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

        [ForeignKey("ToCart")]
        public long ToCartID { get; set; }
        public virtual Cart ToCart { get; set; }

        [ForeignKey("FromCart")]
        public long FromCartID { get; set; }
        public virtual Cart FromCart { get; set; }
    }
   
}
