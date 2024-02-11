using Account.Infrastructure.Library.Patterns;
using log4net.Util;
using Account.Presentation.Extentions;
using Account.Presentation.Forms;
using Account.Presentation.Generator;
using System.Data;

namespace Account.Presentation.UserControls
{
    public partial class BankUC : UserControl
    {
        private IFacadPattern Pattern;
        public BankUC()
        {
            InitializeComponent();
            Pattern = new FacadPattern();
        }
        private void ShowDataGrid()
        {
            GridData.DataSource = Pattern.ExecuteQuery(Pattern.BankService.ShowAll(Pattern.Paging.Order(Pattern.Paging.Page)));
            var count = (Pattern.ExecuteQuery(Pattern.BankService.GetCount())).Rows[0].Field<int>(0); ;
            PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {Pattern.Paging.Page + 1}";

        }

        private void BankUC_Load(object sender, EventArgs e)
        {
            ShowDataGrid();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var data = Pattern.BankService.GetData();
            }
            catch (Exception ex)
            {
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            BankNewForm bankNewForm = new BankNewForm();
            bankNewForm.ShowDialog();
            ShowDataGrid();
        }
    }
}
