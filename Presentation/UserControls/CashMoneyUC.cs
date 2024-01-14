using Infrastructure.Library.Patterns;
using Presentation.Forms;
using System.Data;

namespace Presentation.UserControls
{
    public partial class CashMoneyUC : UserControl
    {

        public CashMoneyUC()
        {
            InitializeComponent();
        }
        private void ShowDataGrid()
        {
            GridData.DataSource = pattern.ExecuteQuery(unitOfWork.BlanceService.ShowAll(unitOfWork.Paging.Order(unitOfWork.Paging.Page)));
            var count = (pattern.ExecuteQuery(unitOfWork.BlanceService.GetCount())).Rows[0].Field<int>(0); ;
            PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {unitOfWork.Paging.Page + 1}";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            CashMoneyNewForm cashMoneyNewForm = new CashMoneyNewForm();
            cashMoneyNewForm.ShowDialog();
            ShowDataGrid();
        }
    }
}
