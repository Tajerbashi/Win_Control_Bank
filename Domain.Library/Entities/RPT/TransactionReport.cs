using Domain.Library.Bases;
using Domain.Library.Entities.BUS;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.RPT
{
    [Table("TransactionReports", Schema = "RPT")]
    public class TransactionReport : GeneralEntity
    {
        [ForeignKey("Transaction")]
        public long TransactionID { get; set; }
        public Transaction Transaction { get; set; }
    }
}
