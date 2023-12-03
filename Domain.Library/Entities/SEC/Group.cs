using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.SEC
{
    [Table("Groups", Schema = "SEC")]
    public class Group : BaseEntity
    {
        public virtual List<GroupUser> GroupUsers { get; set; }
    }
}
