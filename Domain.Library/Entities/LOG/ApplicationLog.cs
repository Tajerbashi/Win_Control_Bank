using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.LOG
{
    [Table("ApplicationLogs", Schema = "LOG")]
    public class ApplicationLog : BaseEntity
    {
    }
}
