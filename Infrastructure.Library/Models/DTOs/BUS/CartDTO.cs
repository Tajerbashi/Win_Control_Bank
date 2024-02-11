using Account.Domain.Library.Enums;
using Account.Infrastructure.Library.BaseModels;
using Account.Infrastructure.Library.Models.DTOs.LOG;
using Account.Infrastructure.Library.Models.DTOs.RPT;

namespace Account.Infrastructure.Library.Models.DTOs.BUS
{
    public class CartDTO : BaseDTO
    {
        /// <summary>
        /// نام حساب
        /// </summary>
        public string AccountNumber { get; set; }
        /// <summary>
        /// کارت شبا
        /// </summary>
        public string ShabaAccountNumber { get; set; }
        /// <summary>
        /// تصویر
        /// </summary>
        public string Picture { get; set; }
        /// <summary>
        /// کلید
        /// </summary>
        public Guid Key { get; set; }
        /// <summary>
        /// تاریخ انقضاء
        /// </summary>
        public DateTime ExpireDate { get; set; }
        /// <summary>
        /// کلید بانک
        /// </summary>
        public long BankID { get; set; }
        /// <summary>
        /// کلید مشترک
        /// </summary>
        public long CustomerID { get; set; }
        /// <summary>
        /// کلید والد
        /// </summary>
        public long? ParentID { get; set; }
        /// <summary>
        /// نوع کارت
        /// </summary>
        public CartType CartType { get; set; }
        public List<BlanceDTO> Blances { get; set; }
        public List<EventLogDTO> CartLogs { get; set; }
        public List<CartReportDTO> CartReports { get; set; }
        
        //public string CartTypeTitle { get => CartType.; }
    }
}
