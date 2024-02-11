using Account.Applicatino.Library.Patterns;
using Account.Application.Library.Patterns;
using Account.Presentation.Forms;
using System.Data;

namespace Account.Presentation.UserControls
{
    public partial class CashMoneyUC : UserControl
    {
        private IFacadPattern Pattern;

        public CashMoneyUC()
        {
            InitializeComponent();
            Pattern = new FacadPattern();
        }
        private void ShowDataGrid()
        {
            GridData.DataSource = Pattern.ExecuteQuery(Pattern.BlanceRepository.ShowAll(Pattern.Paging.Order(Pattern.Paging.Page)));
            var count = (Pattern.ExecuteQuery(Pattern.BlanceRepository.GetCount())).Rows[0].Field<int>(0); ;
            PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {Pattern.Paging.Page + 1}";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            CashMoneyNewForm cashMoneyNewForm = new CashMoneyNewForm();
            cashMoneyNewForm.ShowDialog();
            ShowDataGrid();
        }
    }
}
