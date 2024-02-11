using Account.Application.Library.BaseModels;

namespace Account.Application.Library.Models.DTOs.CNT
{
    public class ConstVariableDTO : GeneralDTO
    {
        public long? ParentId { get; set; }
        public string Key { get; set; }
        public byte Type { get; set; }
        public string Value { get; set; }
    }
}
