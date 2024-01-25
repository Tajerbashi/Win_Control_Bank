using Infrastructure.Library.BaseModels;

namespace Infrastructure.Library.Models.DTOs.LOG
{
    public class SystemLogDTO : BaseDTO
    {
        public string Key { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
    }
}
