using Domain.Library.Bases;
using Domain.Library.Entities.LOG;
using Domain.Library.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.BUS
{
    [Table("Blances", Schema = "BUS")]
    public class Blance : BaseEntity
    {
        [Description("موجودی قبلی")]
        public double LastCash { get; set; }
        [Description("موجودی فعلی")]
        public double Cash { get; set; }

        [Description("نوع موجودی")]
        public BlanceType BlanceType { get; set; }

        [ForeignKey("Cart")]
        public long CartID { get; set; }
        public virtual Cart Cart { get; set; }

        public virtual List<BlanceLog> BlanceLogs { get; set; }

    }
}
