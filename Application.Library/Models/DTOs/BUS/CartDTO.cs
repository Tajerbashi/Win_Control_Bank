using Domain.Library.Entities.BUS;
using Domain.Library.Entities.LOG;
using Domain.Library.Entities.RPT;
using Infrastructure.Library.BaseModels;
using Infrastructure.Library.Models.DTOs.LOG;
using Infrastructure.Library.Models.DTOs.RPT;

namespace Infrastructure.Library.Models.DTOs.BUS
{
    public class CartDTO : BaseDTO
    {
        public string AccountNumber { get; set; }
        public string ShabaAccountNumber { get; set; }
        public string Picture { get; set; }
        public Guid Key { get; set; }
        public DateTime ExpireDate { get; set; }
        public long BankID { get; set; }
        public long CustomerID { get; set; }

        public List<CartHistoryDTO> CartHistories { get; set; }
        public List<CartTransactionDTO> CartTransactions { get; set; }
        public List<BlanceDTO> Blances { get; set; }
        public List<CartLogDTO> CartLogs { get; set; }
        public List<CartReportDTO> CartReports { get; set; }
    }
}
