using Infrastructure.Library.BaseModels;
using System.ComponentModel;

namespace Infrastructure.Library.Models.DTOs.BUS
{
    public class CustomerDTO : BaseDTO
    {
        public string FullName { get; set; }
        public Guid Key { get; set; }
        public string Picture { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
