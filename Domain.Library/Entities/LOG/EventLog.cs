using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.LOG
{
    [Table("EventLogs", Schema = "LOG")]
    public class EventLog : GeneralEntity
    {
    }
}
