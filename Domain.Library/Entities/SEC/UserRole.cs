using Account.Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Account.Domain.Library.Entities.SEC
{
    [Table("UserRoles", Schema = "SEC")]
    public class UserRole : BaseEntity
    {
        [ForeignKey("User")]
        public long UserID { get; set; }
        public User User { get; set; }

        [ForeignKey("Role")]
        public long RoleID { get; set; }
        public Role Role { get; set; }
    }
}
