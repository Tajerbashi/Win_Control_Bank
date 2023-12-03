using Domain.Library.Bases;
using Domain.Library.Entities.BUS;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.LOG
{
    [Table("BlanceLogs", Schema = "LOG")]
    public class BlanceLog : GeneralEntity
    {
        [ForeignKey("Blance")]
        public long BlanceID { get; set; }
        public Blance Blance { get; set; }
    }
}
