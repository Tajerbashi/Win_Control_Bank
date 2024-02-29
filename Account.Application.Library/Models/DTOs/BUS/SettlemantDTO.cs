
using Account.Application.Library.BaseModels;

namespace Account.Application.Library.Models.DTOs.BUS
{
    public class SettlemantDTO : BaseDTO
    {
        public int Year { get; set; }
        public byte Month { get; set; }
        public byte Day { get; set; }
        public Guid TransactionID { get; set; }
        public double Cash { get; set; }
        public DateTime Date { get; set; }
        public long CartID { get; set; }
    }
}
