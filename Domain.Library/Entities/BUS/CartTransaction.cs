using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.BUS
{
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
