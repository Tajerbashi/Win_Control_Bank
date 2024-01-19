using Infrastructure.Library.BaseModels;

namespace Infrastructure.Library.Models.Views.BUS
{
    public class CartHistoryView : BaseView
    {
        public int CartID { get; set; }
        public string AccountNumber { get; set; }
        public int CartType { get; set; }
        public string FullName { get; set; }
        public int TransactionID { get; set; }
        public double Cash { get; set; }
        public int TransactionType { get; set; }
        public int BlanceID { get; set; }
        public double BlanceCash { get; set; }
        public int BlanceType { get; set; }
        public int CartHistoryID { get; set; }
        public bool IsCashable { get; set; }
        public string Message { get; set; }
    }
}
