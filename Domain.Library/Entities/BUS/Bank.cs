using Domain.Library.Bases;
using Domain.Library.Entities.RPT;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.BUS
{
    [Table("Banks", Schema = "BUS")]
    public class Bank : GeneralEntity
    {
        [Description("نام بانک")]
        public string BankName { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<BankReport> BankReports { get; set; }
    }
}
