using Domain.Library.Bases;
using Domain.Library.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.WEB
{
    [Table("WebServices", Schema = "WEB")]
    public class WebService : GeneralEntity
    {
        public string API { get; set; }
        public WebServiceType Type { get; set; }
        public string Parameters { get; set; }
    }
}
