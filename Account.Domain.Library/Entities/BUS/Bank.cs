using Account.Domain.Library.Bases;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Account.Domain.Library.Entities.BUS
{
    [Table("Banks", Schema = "BUS")]
    public class Bank : BaseEntity
    {
        [Description("نام بانک")]
        public string BankName { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
