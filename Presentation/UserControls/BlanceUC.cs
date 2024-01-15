using Infrastructure.Library.Patterns;

namespace Presentation.UserControls
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
