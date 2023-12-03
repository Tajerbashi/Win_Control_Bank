using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.LOG
{
    [Table("BlanceLogs", Schema = "LOG")]
    public class BlanceLog : GeneralEntity
    {
    }
}
