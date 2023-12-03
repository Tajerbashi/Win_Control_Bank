using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.SEC
{
    [Table("GroupUsers", Schema = "SEC")]
    public class GroupUser : BaseEntity
    {
        [ForeignKey("User")]
        public long UserID { get; set; }
        public User User { get; set; }

        [ForeignKey("Group")]
        public long GroupID { get; set; }
        public Group Group { get; set; }

    }
}
