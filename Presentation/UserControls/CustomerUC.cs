using Dapper;
using Account.Application.Library.Models.DTOs.SEC;
using Account.Application.Library.Patterns;
using Account.Presentation.Forms;
using Account.Presentation.Generator;
using System.Data;

namespace Account.Presentation.UserControls
{
    public partial class CustomerUS : UserControl
    {
        private IFacadPattern Pattern;

        public CustomerUS()
        {
            InitializeComponent();
            Pattern = new FacadPattern();
        }
        private void ShowDataGrid()
        {
            CustomerCombo = ComboBoxGenerator<long>.FillData(CustomerCombo, Pattern.CustomerService.TitleValue(), Convert.ToByte(CustomerCombo.Tag));
            GridData.DataSource = Pattern.ExecuteQuery(Pattern.CustomerService.ShowAll(Pattern.Paging.Order(Pattern.Paging.Page)));
            var count = (Pattern.ExecuteQuery(Pattern.CustomerService.GetCount())).Rows[0].Field<int>(0); ;
            PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {Pattern.Paging.Page + 1}";
        }

        private void UserUS_Load(object sender, EventArgs e)
        {
            ShowDataGrid();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            CustomerNewForm form = new CustomerNewForm();
            form.ShowDialog();
            ShowDataGrid();
        }
    }
}
