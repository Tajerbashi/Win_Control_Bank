using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Patterns;
using Account.Infrastructure.Library.Repositories.BUS.Queries;
using Account.Presentation.Extentions;
using Account.Presentation.Generator;
using Azure;
using FluentValidation;
using FluentValidation.Results;

namespace Account.Presentation.Forms
{
    public partial class SettlemantForm : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private Guid transactionId;
        private IValidator<BlanceDTO> _blanceValidator;
        private IValidator<SettlemantDTO> _settlemantValidator;

        public SettlemantForm(
            IUnitOfWork unitOfWork,
            IValidator<BlanceDTO> blanceValidator,
            IValidator<SettlemantDTO> settlemantValidator
            )
        {
            _unitOfWork = unitOfWork;
            _blanceValidator = blanceValidator;
            _settlemantValidator = settlemantValidator;
            InitializeComponent();
        }


       
        
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            transactionId = Guid.NewGuid();
            var blanceDto = BlanceDTO();
            if (blanceDto.Item1)
            {
                _unitOfWork.BeginTransaction();
                try
                {
                    _unitOfWork.BlanceRepository.DisActiveLastBankingBlanceOfCartById(blanceDto.Item2.CartID);
                    _unitOfWork.BlanceRepository.Insert(blanceDto.Item2);
                    var settlemantDto = SettlemantDTO(blanceDto.Item2.CartID);
                    if (settlemantDto.Item1)
                    {
                        _unitOfWork.SettlemantRepository.Insert(settlemantDto.Item2);
                        _unitOfWork.Commit();
                        CloseForm();
                    }
                    else
                    {
                        _unitOfWork.Rollback();
                    }
                }
                catch
                {
                    _unitOfWork.Rollback();

                }
            }

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

        private (bool, BlanceDTO) BlanceDTO()
        {
            var account = AccountCombo.SelectedItem as KeyValue<long>;

            var lastCash = _unitOfWork.BlanceRepository.GetBankingBlanceByCartId(account.Value);
            var cash = Convert.ToDouble(CashTxt.Text);
            var newCash = cash + lastCash.Value;


            var model = new BlanceDTO()
            {
                BlanceType = Domain.Library.Enums.BlanceType.Banking,
                Description = DescTxt.Text,
                TransactionID = transactionId,
                OldBlanceCash = lastCash.Value,
                TransactionCash = cash,
                NewBlanceCash = newCash,
                TransactionType = Domain.Library.Enums.TransactionType.Settlemant,
                CartID = account.Value,
            };
            ValidationResult result = _blanceValidator.Validate(model);
            if (!result.IsValid)
            {
                MSG.Text = result.Errors.Select(x => ($"{x.ErrorMessage} : {x.AttemptedValue}")).FirstOrDefault();
                return (false, model);
            }
            return (true, model);
        }

        private (bool, SettlemantDTO) SettlemantDTO(long cartId)
        {
            var Year = (YearCombo.SelectedItem as KeyValue<int>).Value;
            var Month = (MonthCombo.SelectedItem as KeyValue<int>).Value;
            var Day = (MonthCombo.SelectedItem as KeyValue<int>).Value;
            var dateTime = DateUtilities.ToGreGorianDateTime(Year,(byte)Month,(byte)Day);
            var model = new SettlemantDTO()
            {
                CartID = cartId,
                Cash = Convert.ToDouble(CashTxt.Text),
                Date = dateTime,
                Year = Year,
                Month = (byte)Month,
                Day = (byte)Day,
                TransactionID = transactionId,
            };
            ValidationResult result = _settlemantValidator.Validate(model);
            if (!result.IsValid)
            {

                return (false, model);
            }
            return (true, model);
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

        private void CloseForm()
        {
            FormExtentions.ClearTextBoxes(this.Controls);
            AccountCombo.Items.Clear();
            CustomerCombo.SelectedIndex = 0;
            CashTxt.Text = string.Empty;
            MSG.Text = "";
            this.Close();
        }
        #endregion
    }
}
