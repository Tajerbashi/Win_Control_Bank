using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.RPT
{
    [Table("CartReports", Schema = "RPT")]
    public class CartReport : GeneralEntity
    {
    }
}
