using Domain.Library.Bases;
using Domain.Library.Entities.BUS;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.LOG
{
    [Table("CustomerLogs", Schema = "LOG")]
    public class CustomerLog : GeneralEntity
    {
        [ForeignKey("Customer")]
        public long CustomerID { get; set; }
        public Customer Customer { get; set; }
    }
}
