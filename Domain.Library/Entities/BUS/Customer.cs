using Domain.Library.Bases;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.BUS
{
    [Table("Customers", Schema = "BUS")]
    public class Customer : GeneralEntity
    {
        [Description("نام کامل")]
        public string FullName { get; set; }
        [Description("کلید")]
        public Guid Key { get; set; }

        [Description("تصویر")]
        public string Picture { get; set; }

        public virtual List<Cart> Carts { get; set; }

    }
}
