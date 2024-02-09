using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.LOG
{
    [Table("EventLogs", Schema = "LOG")]
    public class EventLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public DateTime Date { get; set; }
        [MaxLength(255)]
        public string Thread { get; set; }
        [MaxLength(50)]
        public string Level { get; set; }
        [MaxLength(255)]
        public string Logger { get; set; }
        [MaxLength(4000)]
        public string Message { get; set; }
        [MaxLength(2000)]
        public string Exception { get; set; }
    }
}
