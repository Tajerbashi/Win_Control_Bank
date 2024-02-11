using Account.Application.Library.BaseModels;

namespace Account.Application.Library.Models.Views.WEB
{
    public class WebServiceView : BaseView
    {
        public string Value { get; set; }
        public string Change { get; set; }
        public string TimeStamp { get; set; }
        public string Date { get; set; }
    }
}
