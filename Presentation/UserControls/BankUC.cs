using Infrastructure.Library.Patterns;
using Presentation.Forms;
using System.Data;

namespace Presentation.UserControls
{
    public partial class BankUC : UserControl
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IFacadPattern pattern;
        public BankUC()
        {
            unitOfWork = new UnitOfWork();
            pattern = new FacadPattern();
            InitializeComponent();
        }
        private void ShowDataGrid()
        {
            GridData.DataSource = pattern.ExecuteQuery(unitOfWork.BankService.ShowAll(unitOfWork.Paging.Order(unitOfWork.Paging.Page)));
            var count = (pattern.ExecuteQuery(unitOfWork.BankService.GetCount())).Rows[0].Field<int>(0); ;
            PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {unitOfWork.Paging.Page + 1}";

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            BankNewForm bankNewForm = new BankNewForm();
            bankNewForm.ShowDialog();
            ShowDataGrid();

        }

        private void BankUC_Load(object sender, EventArgs e)
        {
            ShowDataGrid();
        }
    }
}
