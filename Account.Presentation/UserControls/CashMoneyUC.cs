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
        private CashableBlanceForm CashableBlanceForm;
        public CashMoneyUC(
            IBlanceRepository blanceRepository,
            ICartRepository cartRepository,
            CashableBlanceForm cashableBlanceForm
            )
        {
            _blanceRepository = blanceRepository;
            _cartRepository = cartRepository;
            this.CashableBlanceForm = cashableBlanceForm;
            InitializeComponent();
        }
        private void ShowDataGrid()
        {
            GridData.DataSource = _blanceRepository.ExecuteQuery(_blanceRepository.ShowAllCashableBlances(_blanceRepository.Paging.Order(_blanceRepository.Paging.Page)));
            var count = (_blanceRepository.ExecuteQuery(_blanceRepository.GetCount())).Rows[0].Field<int>(0); ;
            PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {_blanceRepository.Paging.Page + 1}";
            CartCombo = ComboBoxGenerator<long>.FillData(CartCombo, _cartRepository.TitleValuesParent(), Convert.ToByte(CartCombo.Tag));
        }

        private void CashMoneyUC_Load(object sender, EventArgs e)
        {
            ShowDataGrid();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.CashableBlanceForm.ShowDialog();
            ShowDataGrid();
        }

        private void FillComboBoxes()
        {

        }
    }
}
