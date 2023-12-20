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
        [Description("موجودی")]
        public double BlanceCash { get; set; }

        [Description("نوع موجودی")]
        public BlanceType BlanceType { get; set; }

        [ForeignKey("Transaction")]
        public long TransactionID { get; set; }
        public virtual Transaction Transaction { get; set; }

        public virtual BlanceCustomer BlanceCustomer { get; set; }

        public virtual List<BlanceLog> BlanceLogs { get; set; }
    }
}
