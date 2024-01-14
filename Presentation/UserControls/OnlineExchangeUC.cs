using Infrastructure.Library.Patterns;
using Infrastructure.Library.WebServices;

namespace Presentation.UserControls
{
    public partial class OnlineExchangeUC : UserControl
    {

        public OnlineExchangeUC()
        {
            InitializeComponent();
        }
        private void OnlineExchangeUC_Load(object sender, EventArgs e)
        {
            var data = ExchangeRateApiService.GetOfflineData();
        }



    }
}
