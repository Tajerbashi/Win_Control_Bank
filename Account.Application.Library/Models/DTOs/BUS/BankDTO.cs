
using Account.Application.Library.BaseModels;
using Account.Domain.Library.Entities.BUS;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Account.Application.Library.Models.DTOs.BUS
{
    public class BankDTO : BaseDTO
    {
        /// <summary>
        /// BankName
        /// </summary>
        public string BankName { get; set; }
    }
}
