using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.LOG
{
    [Table("SecurityLogs", Schema = "LOG")]
    public class SecurityLog : GeneralEntity
    {
    }
}
