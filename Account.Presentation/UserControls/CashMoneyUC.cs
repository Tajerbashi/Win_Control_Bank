using Account.Application.Library.Patterns;
using Account.Application.Library.Repositories.BUS;
using Account.Presentation.Forms;
using System.Data;

namespace Account.Presentation.UserControls
{
    public partial class CashMoneyUC : UserControl
    {
        private readonly IBlanceRepository _blanceRepository;
        private CashMoneyNewForm cashMoneyNewForm;
        public CashMoneyUC(IBlanceRepository blanceRepository, CashMoneyNewForm cashMoneyNewForm)
        {
            _blanceRepository = blanceRepository;
            this.cashMoneyNewForm = cashMoneyNewForm;
            InitializeComponent();
        }
        private void ShowDataGrid()
        {
            GridData.DataSource = _blanceRepository.ExecuteQuery(_blanceRepository.ShowAll(_blanceRepository.Paging.Order(_blanceRepository.Paging.Page)));
            var count = (_blanceRepository.ExecuteQuery(_blanceRepository.GetCount())).Rows[0].Field<int>(0); ;
            PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {_blanceRepository.Paging.Page + 1}";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            
            cashMoneyNewForm.ShowDialog();
            ShowDataGrid();
        }
    }
}
