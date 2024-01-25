using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.LOG
{
    [Table("SetupLogs", Schema = "LOG")]
    public class SetupLog : GeneralEntity
    {
    }
}
