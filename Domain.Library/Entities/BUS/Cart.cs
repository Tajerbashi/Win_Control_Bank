using Domain.Library.Bases;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.BUS
{
    [Table("Carts", Schema = "BUS")]
    public class Cart : BaseEntity
    {
        [Description("شماره حساب")]
        public string AccountNumber { get; set; }
        [Description("کلید اختصاصی")]
        public Guid Key { get; set; }
        [Description("تاریخ انقضاء")]
        public DateTime ExpireDate { get; set; }




        //  Relations
        [ForeignKey("Bank")]
        public long BankID { get; set; }
        public virtual Bank Bank { get; set; }

        [ForeignKey("Customer")]
        public long CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual List<CartHitory> CartHitories { get; set; }
        public virtual List<Transaction> Transactions { get; set; }
        public virtual List<Blance> Blances { get; set; }

    }
}
