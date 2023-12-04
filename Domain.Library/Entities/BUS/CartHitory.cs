using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.BUS
{
    [Table("CartHistories", Schema = "BUS")]
    public class CartHistory : BaseEntity
    {
        [ForeignKey("Cart")]
        public long CartID { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
