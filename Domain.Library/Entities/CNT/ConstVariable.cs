using Account.Domain.Library.Bases;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Account.Domain.Library.Entities.CNT
{
    [Table("ConstVariables", Schema = "CNT")]
    public class ConstVariable : GeneralEntity
    {
        [ForeignKey(nameof(ConstVariableChild))]
        public long? ParentId { get; set; }
        public ConstVariable ConstVariableChild { get; set; }

        [Description("کلید")]
        public string Key { get; set; }

        [Description("نوع")]
        public byte Type { get; set; }

        [Description("مقدار")]
        public string Value { get; set; }

    }
}
