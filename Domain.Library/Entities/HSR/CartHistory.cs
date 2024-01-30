using Domain.Library.Bases;
using Domain.Library.Entities.BUS;
using Domain.Library.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.HSR
{
    [Table("CartHistories", Schema = "HSR")]
    public class CartHistory : GeneralEntity
    {
        [Description("نوع تراکنش")]
        public TransactionType TransactionType { get; set; }
      
        [Description("نوع موجودی")]
        public BlanceType BlanceType { get; set; }
      
        [Description("مبلغ تراکنش")]
        public double CashTransaction { get; set; }
        
        [Description("پیام")]
        public string Message { get; set; }
       
        [Description("کلید تراکنش  و موجودی جدید")]
        public long BlanceID { get; set; }

        [Description("کارت مبداء")]
        public long FromCartID { get; set; }

        [Description("کارت مقصد")]
        public long ToCartID { get; set; }

        [ForeignKey("Cart")]
        public long CartID { get; set; }
        public Cart Cart { get; set; }
    }
}
