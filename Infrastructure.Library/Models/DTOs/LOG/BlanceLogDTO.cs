using Account.Infrastructure.Library.BaseModels;

namespace Account.Infrastructure.Library.Models.DTOs.LOG
{
    public class BlanceLogDTO : BaseDTO
    {
        public string Key { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
    }
}
