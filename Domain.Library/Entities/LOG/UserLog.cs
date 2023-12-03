using Domain.Library.Bases;
using Domain.Library.Entities.SEC;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.LOG
{
    [Table("UserLogs", Schema = "LOG")]
    public class UserLog : GeneralEntity
    {

        [ForeignKey("User")]
        public long UserID { get; set; }
        public User User { get; set; }
    }
}
