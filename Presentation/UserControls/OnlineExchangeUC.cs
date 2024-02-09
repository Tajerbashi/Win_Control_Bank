using Infrastructure.Library.Patterns;

namespace Presentation.UserControls
{
    public partial class OnlineExchangeUC : UserControl
    {
        private IFacadPattern Pattern;

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
