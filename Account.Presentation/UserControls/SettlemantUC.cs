using Account.Presentation.Forms;

namespace Account.Presentation.UserControls
{
    public partial class SettlemantUC : UserControl
    {
        private SettlemantForm SettlemantForm;
        public SettlemantUC(
            SettlemantForm SettlemantForm
            )
        {
            this.SettlemantForm = SettlemantForm;
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            SettlemantForm.ShowDialog();
        }
    }
}
