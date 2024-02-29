using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Patterns;
using Account.Presentation.Extentions;
using Account.Presentation.Generator;

namespace Account.Presentation.Forms
{
    public partial class SettlemantForm : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private Guid transactionId;
        public SettlemantForm(
            IUnitOfWork unitOfWork
            )
        {
            _unitOfWork = unitOfWork;
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            transactionId = Guid.NewGuid();
        }

        private void SettlemantForm_Load(object sender, EventArgs e)
        {
            UpdateComboBoxes();
        }

        private void UpdateComboBoxes()
        {
            CustomerCombo = ComboBoxGenerator<long>.FillData(CustomerCombo, _unitOfWork.CustomerRepository.CustomerTitleValue(), Convert.ToByte(CustomerCombo.Tag));
            YearCombo = ComboBoxGenerator<int>.FillData(YearCombo, DateUtilities.TitleValueYear(), Convert.ToByte(YearCombo.Tag));
            MonthCombo = ComboBoxGenerator<int>.FillData(MonthCombo, DateUtilities.TitleValueMonthPersian(), Convert.ToByte(MonthCombo.Tag));
            DayCombo = ComboBoxGenerator<int>.FillData(DayCombo, DateUtilities.TitleValueDay(), Convert.ToByte(DayCombo.Tag));
        }

        private BlanceDTO BlanceDTO()
        {
            return new BlanceDTO()
            {
                TransactionID = transactionId,
            };
        }

        private SettlemantDTO SettlemantDTO()
        {
            return new SettlemantDTO()
            {
                TransactionID = transactionId
            };
        }

        #region EventControl
        private void CustomerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var CustomerId = CustomerCombo.SelectedItem as KeyValue<long>;
            if (CustomerId is not null)
            {
                if (CustomerId.Value != 0)
                {
                    AccountCombo = ComboBoxGenerator<long>.FillData(AccountCombo, _unitOfWork.CartRepository.TitleValueByUserID(CustomerId.Value), Convert.ToByte(AccountCombo.Tag));
                }
                else
                {
                    AccountCombo.Items.Clear();
                }

            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            FormExtentions.ClearTextBoxes(this.Controls);
            MSG.Text = "";
            DescTxt.Text = string.Empty;
            CashTxt.Text = string.Empty;
            this.Close();
        }

        private void CashTxt_TextChanged(object sender, EventArgs e)
        {
            if (CashTxt.Text == "" || CashTxt.Text == "0") return;
            CashTxt = InputUtilities.Thirth3Numeric(CashTxt);
        }
        #endregion
    }
}
