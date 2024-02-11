using Account.Infrastructure.Library.Patterns;

namespace Account.Presentation.UserControls
{
    public partial class BlanceUC : UserControl
    {
        private IFacadPattern Pattern;
        public BlanceUC()
        {
            InitializeComponent();
            Pattern = new FacadPattern();
        }
    }
}
