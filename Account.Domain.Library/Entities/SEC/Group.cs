using Account.Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Account.Domain.Library.Entities.SEC
{
    [Table("Groups", Schema = "SEC")]
    public class Group : BaseEntity
    {
        public virtual ICollection<GroupUser> GroupUsers { get; set; }
    }
}
