using Account.Domain.Library.Bases;
using Account.Domain.Library.Entities.BUS;
using Account.Domain.Library.Entities.SEC;
using System.ComponentModel.DataAnnotations.Schema;

namespace Account.Domain.Library.Entities.RPT
{
    [Table("CartReports", Schema = "RPT")]
    public class CartReport : GeneralEntity
    {
        [ForeignKey("Cart")]
        public long CartID { get; set; }
        public Cart Cart { get; set; }
    }
}
