using Domain.Library.Bases;
using Domain.Library.Entities.BUS;
using Domain.Library.Entities.SEC;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.RPT
{
    [Table("CartReports", Schema = "RPT")]
    public class CartReport : GeneralEntity
    {
        [ForeignKey("Cart")]
        public long CartID { get; set; }
        public Cart Cart { get; set; }
    }
}
