using Presentation.Forms;

namespace Presentation.UserControls
{
    public partial class TransactionUC : UserControl
    {
        public TransactionUC()
        {
            InitializeComponent();
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
