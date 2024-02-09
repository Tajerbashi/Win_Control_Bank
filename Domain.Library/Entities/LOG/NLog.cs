using Domain.Library.Bases;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.LOG
{
    [Table("NLog", Schema = "LOG")]
    public class NLog : BaseEntity
    {
        [Description("تاریخ")]
        public DateTime Date { get; set; }


        [MaxLength(255)]
        [Description("مسیر")]
        public string Thread { get; set; }


        [MaxLength(50)]
        [Description("رتبه")]
        public string Level { get; set; }


        [MaxLength(255)]
        [Description("اطلاعات")]
        public string Logger { get; set; }


        [MaxLength(4000)]
        [Description("پیام")]
        public string Message { get; set; }


        [MaxLength(255)]
        [Description("سرویس")]
        public string Service { get; set; }


        [MaxLength(255)]
        [Description("متد")]
        public string Method { get; set; }


        [MaxLength(255)]
        [Description("پارامتر های ارسالی")]
        public string RequestData { get; set; }


        [MaxLength(255)]
        [Description("پارامتر های دریافتی")]
        public string ResponseData { get; set; }


        [MaxLength(2000)]
        [Description("استثناء")]
        public string Exception { get; set; }


    }
}
