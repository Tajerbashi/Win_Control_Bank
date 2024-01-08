using Infrastructure.Library.Patterns;
using Infrastructure.Library.WebServices;
using System.Data;

namespace Presentation.UserControls
{
    public partial class OnlineExchangeUC : UserControl
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IFacadPattern pattern;

        public OnlineExchangeUC()
        {
            unitOfWork = new UnitOfWork();
            pattern = new FacadPattern();
            InitializeComponent();
        }
        private void OnlineExchangeUC_Load(object sender, EventArgs e)
        {
           var data =  ExchangeRateApiService.GetOfflineData();
        }



    }
}
