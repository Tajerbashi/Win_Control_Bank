using Infrastructure.Library.Patterns;
using Presentation.Forms;

namespace Presentation.UserControls
{
    public partial class TransactionUC : UserControl
    {
        private readonly IFacadPattern Pattern;
        public TransactionUC()
        {
            InitializeComponent();
            Pattern = new FacadPattern();
        }
        private void ShowDataGrid()
        {
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            TransactionNewForm transaction = new TransactionNewForm();
            transaction.ShowDialog();
            ShowDataGrid();
        }


    }
}
