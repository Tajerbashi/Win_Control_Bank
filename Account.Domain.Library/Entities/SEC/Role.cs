using Account.Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Account.Domain.Library.Entities.SEC
{
    [Table("Role", Schema = "SEC")]
    public class Role : BaseEntity
    {
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
