using Account.Application.Library.BaseModels;

namespace Account.Application.Library.Models.Views.BUS
{
    public class SettlemantView : BaseView
    {
        public string Year { get; set; }
        public byte Month { get; set; }
        public byte Day { get; set; }
        public Guid TransactionID { get; set; }
        public double Cash { get; set; }
        public DateTime Date { get; set; }
        public long CartID { get; set; }
    }
}
