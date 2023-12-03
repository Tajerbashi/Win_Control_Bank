using Domain.Library.Bases;
using Domain.Library.Entities.BUS;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.RPT
{
    [Table("BankReports", Schema = "RPT")]
    public class BankReport : GeneralEntity
    {
        [ForeignKey("Bank")]
        public long BankID { get; set; }
        public Bank Bank { get; set; }
    }
}
