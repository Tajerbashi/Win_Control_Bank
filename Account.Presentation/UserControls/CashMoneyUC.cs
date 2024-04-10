using Account.Application.Library.Models.Controls;
using Account.Application.Library.Repositories.BUS;
using Account.Domain.Library.Enums;
using Account.Presentation.Extentions;
using Account.Presentation.Forms;
using Account.Presentation.Generator;
using System.Data;

namespace Account.Presentation.UserControls
{
    public partial class CashMoneyUC : UserControl
    {
        private readonly IBlanceRepository _blanceRepository;
        private readonly ICartRepository _cartRepository;
        private readonly ICustomerRepository _customerRepository;
        private CashableBlanceForm CashableBlanceForm;
        private byte TransactionType;
        public CashMoneyUC(
            IBlanceRepository blanceRepository,
            ICartRepository cartRepository,
            ICustomerRepository customerRepository,
            CashableBlanceForm cashableBlanceForm
            )
        {
            _blanceRepository = blanceRepository;
            _cartRepository = cartRepository;
            _customerRepository = customerRepository;
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
            }
            else
            {
                GridData.DataSource = _blanceRepository.ExecuteQuery(_blanceRepository.ShowCashableTransactionsByCartID(customerID, (TransactionType)TransactionType, _blanceRepository.Paging.Order(_blanceRepository.Paging.Page)));
                var count = (_blanceRepository.ExecuteQuery(_blanceRepository.GetCount())).Rows[0].Field<int>(0); ;
                PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {_blanceRepository.Paging.Page + 1}";
            }
        }

        private void CashMoneyUC_Load(object sender, EventArgs e)
        {
            ShowDataGrid();
            CustomerCombo = ComboBoxGenerator<long>.FillData(CustomerCombo, _customerRepository.CustomerTitleValue(), Convert.ToByte(CustomerCombo.Tag));
            YearCombo = ComboBoxGenerator<int>.FillData(YearCombo, DateUtilities.TitleValueYear(), Convert.ToByte(YearCombo.Tag));
            MonthCombo = ComboBoxGenerator<int>.FillData(MonthCombo, DateUtilities.TitleValueMonthPersian(), Convert.ToByte(MonthCombo.Tag));
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.CashableBlanceForm.ShowDialog();
        }


        private void CustomerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var customer = CustomerCombo.SelectedItem as KeyValue<long>;
        }

        private void YearCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MonthCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
