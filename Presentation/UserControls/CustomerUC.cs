using Dapper;
using Infrastructure.Library.Models.DTOs.SEC;
using Infrastructure.Library.Patterns;
using Presentation.Forms;
using System.Data;

namespace Presentation.UserControls
{
    public partial class CustomerUS : UserControl
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IFacadPattern pattern;
        
        public CustomerUS()
        {
            unitOfWork = new UnitOfWork();
            pattern = new FacadPattern();
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
            UserNewForm form = new UserNewForm();
            form.ShowDialog();
            ShowDataGrid();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
