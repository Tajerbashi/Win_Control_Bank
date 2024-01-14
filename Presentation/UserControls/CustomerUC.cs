using Dapper;
using Infrastructure.Library.Models.DTOs.SEC;
using Infrastructure.Library.Patterns;
using Presentation.Forms;
using System.Data;

namespace Presentation.UserControls
{
    public partial class CustomerUS : UserControl
    {
        
        public CustomerUS()
        {
            InitializeComponent();
        }
        private void ShowDataGrid()
        {
            GridData.DataSource = pattern.ExecuteQuery(unitOfWork.CustomerService.ShowAll(unitOfWork.Paging.Order(unitOfWork.Paging.Page)));
            var count = (pattern.ExecuteQuery(unitOfWork.CustomerService.GetCount())).Rows[0].Field<int>(0); ;
            PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {unitOfWork.Paging.Page + 1}";
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

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
