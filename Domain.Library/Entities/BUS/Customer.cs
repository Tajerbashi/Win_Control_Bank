using Domain.Library.Bases;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.BUS
{
    [Table("Customers", Schema = "BUS")]
    public class Customer : BaseEntity
    {
        [Description("نام کامل")]
        public string FullName { get; set; }
        [Description("کلید")]
        public Guid Key { get; set; }

        public virtual List<Cart> Carts { get; set; }
    }
}
