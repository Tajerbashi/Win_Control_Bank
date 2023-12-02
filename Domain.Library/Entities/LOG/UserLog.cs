using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.LOG
{
    [Table("UserLogs", Schema = "LOG")]
    public class UserLog : GeneralEntity
    {
    }
}
