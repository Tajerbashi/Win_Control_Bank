using Domain.Library.Bases;
using Domain.Library.Entities.BUS;
using Domain.Library.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.LOG
{
    [Table("BlanceLogs", Schema = "LOG")]
    public class BlanceLog : GeneralEntity
    {
        [Description("نوع موجودی")]
        public BlanceType BlanceType { get; set; }
        [Description("نوع تراکنش")]
        public TransactionType TransactionType { get; set; }
        [Description("موجودی فعلی")]
        public double CurrentBlance { get; set; }
        [Description("مبلغ تراکنش")]
        public double TransactionCash { get; set; }
        [Description("موجودی جدید")]
        public double NewBlance { get; set; }

        [ForeignKey("Blance")]
        public long BlanceID { get; set; }
        public Blance Blance { get; set; }
    }
}
