using Domain.Library.Bases;
using Domain.Library.Entities.BUS;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.LOG
{
    [Table("TransactionLogs", Schema = "LOG")]
    public class TransactionLog : GeneralEntity
    {
        [ForeignKey("Transaction")]
        public long TransactionID { get; set; }
        public Transaction Transaction { get; set; }
    }
}
