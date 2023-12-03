using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.LOG
{
    [Table("TransactionLogs", Schema = "LOG")]
    public class TransactionLog : GeneralEntity
    {
    }
}
