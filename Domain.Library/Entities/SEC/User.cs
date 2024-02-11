using Account.Domain.Library.Bases;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Account.Domain.Library.Entities.SEC
{
    [Table("Users", Schema = "SEC")]
    public class User : BaseEntity
    {
        [Description("تصویر")]
        public string Picture { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<GroupUser> GroupUsers { get; set; }
    }
}
