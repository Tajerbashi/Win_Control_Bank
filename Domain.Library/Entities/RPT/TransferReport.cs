using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.RPT
{
    [Table("TransferReports", Schema = "RPT")]
    public class TransferReport : GeneralEntity
    {
    }
}
