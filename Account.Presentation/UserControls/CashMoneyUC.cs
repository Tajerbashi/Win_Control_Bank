using Account.Application.Library.Models.Controls;
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
        private void ShowDataGrid(long customerID = 0)
        {
            if (customerID == 0)
            {
                GridData.DataSource = _blanceRepository.ExecuteQuery(_blanceRepository.ShowAllCashableBlances(_blanceRepository.Paging.Order(_blanceRepository.Paging.Page)));
                var count = (_blanceRepository.ExecuteQuery(_blanceRepository.GetCount())).Rows[0].Field<int>(0); ;
                PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {_blanceRepository.Paging.Page + 1}";
                CustomerCombo = ComboBoxGenerator<long>.FillData(CustomerCombo, _cartRepository.TitleValuesBankingParent(), Convert.ToByte(CustomerCombo.Tag));
            }
            else
            {
                GridData.DataSource = _blanceRepository.ExecuteQuery(_blanceRepository.ShowCashableTransactionsByCartID(customerID,_blanceRepository.Paging.Order(_blanceRepository.Paging.Page)));
                var count = (_blanceRepository.ExecuteQuery(_blanceRepository.GetCount())).Rows[0].Field<int>(0); ;
                PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {_blanceRepository.Paging.Page + 1}";
                CustomerCombo = ComboBoxGenerator<long>.FillData(CustomerCombo, _cartRepository.TitleValuesBankingParent(), Convert.ToByte(CustomerCombo.Tag));
            }
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

        private void CustomerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var customer = CustomerCombo.SelectedItem as KeyValue<long>;
            if (customer is not null)
            {
                ShowDataGrid(customer.Value);
            }
            else
            {
                ShowDataGrid();
            }
        }
    }
}
