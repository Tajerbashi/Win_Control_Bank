using Domain.Library.Bases;
using Domain.Library.Entities.BUS;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.RPT
{
    [Table("CustomerReports", Schema = "RPT")]
    public class CustomerReport : GeneralEntity
    {
        [ForeignKey("Customer")]
        public long CustomerID { get; set; }
        public Customer Customer { get; set; }
    }
}
