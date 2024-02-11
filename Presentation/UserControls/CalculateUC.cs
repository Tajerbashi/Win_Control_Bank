using Account.Application.Library.Patterns;
using System.Data;

namespace Account.Presentation.UserControls
{
    public partial class CalculateUC : UserControl
    {
        private IFacadPattern Pattern;

        public CalculateUC()
        {
            InitializeComponent();
            Pattern = new FacadPattern();
        }
        private void ShowDataGrid()
        {
            GridData.DataSource = Pattern.ExecuteQuery(Pattern.CustomerService.ShowAll(Pattern.Paging.Order(Pattern.Paging.Page)));
            var count = (Pattern.ExecuteQuery(Pattern.CustomerService.GetCount())).Rows[0].Field<int>(0); ;
            PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {Pattern.Paging.Page + 1}";
        }

        private void CalculateUC_Load(object sender, EventArgs e)
        {
            ShowDataGrid();
        }
    }
}
