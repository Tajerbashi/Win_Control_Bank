using Domain.Library.Bases;
using Domain.Library.Entities.BUS;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.LOG
{
    [Table("CartLogs", Schema = "LOG")]
    public class CartLog : GeneralEntity
    {
        [ForeignKey("Cart")]
        public long CartID { get; set; }
        public Cart Cart { get; set; }
    }
}
