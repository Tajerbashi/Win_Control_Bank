using Infrastructure.Library.Models.DTOs.SEC;
using Infrastructure.Library.Patterns;
using Presentation.Extentions;

namespace Presentation.UserControls
{
    public partial class OnlineExchangeUC : UserControl
    {
        private IFacadPattern Pattern;
        private readonly LoggerProvider<OnlineExchangeUC> loggerProvider = new LoggerProvider<OnlineExchangeUC>();

        public OnlineExchangeUC()
        {
            InitializeComponent();
            Pattern = new FacadPattern();
        }
        private void OnlineExchangeUC_Load(object sender, EventArgs e)
        {
        }



    }
}
