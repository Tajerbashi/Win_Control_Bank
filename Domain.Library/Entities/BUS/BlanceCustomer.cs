using Domain.Library.Bases;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.BUS
{
    [Table("BlanceCustomers", Schema = "BUS")]
    public class BlanceCustomer : BaseEntity
    {
        [Description("موجودی")]
        public double BlanceCash { get; set; }

        [Description("از کاربر مالک حساب")]
        public long FromCustomerID { get; set; }

        [Description("به کاربر مالک پول")]
        public long ToCustomerID { get; set; }

        [Description("از کارت مالک حساب")]
        public long FromCartID { get; set; }

        [Description("به کارت مالک پول")]
        public long ToCartID { get; set; }

        [ForeignKey("Blance")]
        public virtual long BlanceID { get; set; }
        public Blance Blance { get; set; }

    }
}
