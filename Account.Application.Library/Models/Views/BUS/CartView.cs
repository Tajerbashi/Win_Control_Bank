using Account.Application.Library.BaseModels;

namespace Account.Application.Library.Models.Views.BUS
{
    public class CartView : BaseView
    {
        public string CustomerName { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public double? Blance { get; set; }
    }
}
