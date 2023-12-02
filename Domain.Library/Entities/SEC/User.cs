using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.SEC
{
    [Table("Users", Schema = "SEC")]
    public class User : BaseEntity
    {
    }
}
