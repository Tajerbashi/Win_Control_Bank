using Domain.Library.Bases;
using Domain.Library.Entities.LOG;
using Domain.Library.Entities.RPT;
using Domain.Library.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.BUS
{
    [Table("Carts", Schema = "BUS")]
    public class Cart : BaseEntity
    {
        [Description("شماره حساب")]
        public string AccountNumber { get; set; }

        [Description("شماره کارت شبا")]
        public string ShabaAccountNumber { get; set; }

        [Description("نوع کارت")]
        public CartType CartType { get; set; }

        [Description("تصویر")]
        public string Picture { get; set; }

        [Description("کلید اختصاصی")]
        public Guid Key { get; set; }

        [Description("تاریخ انقضاء")]
        public DateTime ExpireDate { get; set; }


        //  Relations
        [ForeignKey(nameof(CartChild))]
        public long? ParentID { get; set; }
        public virtual Cart CartChild { get; set; }



        [ForeignKey("Bank")]
        public long BankID { get; set; }
        public virtual Bank Bank { get; set; }

        [ForeignKey("Customer")]
        public long CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        
        //  Child
        public virtual List<Blance> Blances { get; set; }

        

        public virtual ICollection<CartLog> CartLogs { get; set; }

    }
}
