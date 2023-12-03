using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.LOG
{
    [Table("CartLogs", Schema = "LOG")]
    public class CartLog : GeneralEntity
    {
    }
}
