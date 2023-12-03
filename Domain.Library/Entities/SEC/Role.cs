using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.SEC
{
    [Table("Role", Schema = "SEC")]
    public class Role : BaseEntity
    {
        public virtual List<UserRole> UserRoles { get; set; }
    }
}
