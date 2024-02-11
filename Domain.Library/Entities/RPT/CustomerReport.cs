using Account.Domain.Library.Bases;
using Account.Domain.Library.Entities.BUS;
using System.ComponentModel.DataAnnotations.Schema;

namespace Account.Domain.Library.Entities.RPT
{
    [Table("CustomerReports", Schema = "RPT")]
    public class CustomerReport : GeneralEntity
    {
        [ForeignKey("Customer")]
        public long CustomerID { get; set; }
        public Customer Customer { get; set; }
    }
}
