using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.RPT
{
    [Table("BankReports", Schema = "RPT")]
    public class BankReport : GeneralEntity
    {
    }
}
