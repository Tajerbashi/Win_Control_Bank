using Account.Infrastructure.Library.BaseModels;
using System.ComponentModel;

namespace Account.Infrastructure.Library.Models.DTOs.BUS
{
    public class CustomerDTO : BaseDTO
    {
        /// <summary>
        /// نام کامل
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// کلید
        /// </summary>
        public Guid Key { get; set; }
        /// <summary>
        /// تصویر
        /// </summary>
        public string Picture { get; set; }
        
    }
}
