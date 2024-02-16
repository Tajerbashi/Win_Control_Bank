using Account.Application.Library.Repositories.BUS;
using Account.Presentation.Forms;
using Account.Presentation.Generator;
using System.Data;

namespace Account.Presentation.UserControls
{
    public partial class CashMoneyUC : UserControl
    {
        private readonly IBlanceRepository _blanceRepository;
        private readonly ICartRepository _cartRepository;
        private CashMoneyNewForm cashMoneyNewForm;

        private CartNewForm _cartNewForm;
        public CashMoneyUC(
            IBlanceRepository blanceRepository,
            ICartRepository cartRepository,
            CashMoneyNewForm cashMoneyNewForm
            )
        {
            _blanceRepository = blanceRepository;
            _cartRepository = cartRepository;
            this.cashMoneyNewForm = cashMoneyNewForm;
            InitializeComponent();
        }
        private void ShowDataGrid()
        {
            GridData.DataSource = _blanceRepository.ExecuteQuery(_blanceRepository.ShowAllCashableBlances(_blanceRepository.Paging.Order(_blanceRepository.Paging.Page)));
            var count = (_blanceRepository.ExecuteQuery(_blanceRepository.GetCount())).Rows[0].Field<int>(0); ;
            PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {_blanceRepository.Paging.Page + 1}";
            CartCombo = ComboBoxGenerator<long>.FillData(CartCombo, _cartRepository.TitleValuesAllParentCart(), Convert.ToByte(CartCombo.Tag));
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            cashMoneyNewForm.ShowDialog();
            ShowDataGrid();
        }

        private void CashMoneyUC_Load(object sender, EventArgs e)
        {
            ShowDataGrid();
        }
    }
}
