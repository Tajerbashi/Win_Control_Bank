using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Patterns;
using Account.Common.Library.Extentions;
using Account.Domain.Library.Enums;
using Account.Presentation.Extentions;
using Account.Presentation.Generator;
using Microsoft.Identity.Client;
using System.Runtime.InteropServices;

namespace Account.Presentation.Forms
{
    public partial class CashableBlanceForm : Form
    {
        private Guid TransactionID;
        private readonly IUnitOfWork _unitOfWork;

        #region Code
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        System.Windows.Forms.Timer Timer =new System.Windows.Forms.Timer();

        public CashableBlanceForm(
            IUnitOfWork unitOfWork
            )
        {
            _unitOfWork = unitOfWork;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        #endregion

        private void CashableBlanceForm_Load(object sender, EventArgs e)
        {
            FillComboBoxes();
        }


        #region Event
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            TransactionID = Guid.NewGuid();
            var TransactionType = (TransactionTypeCombo.SelectedItem as KeyValue<byte>).Value;
            switch (TransactionType)
            {
                case 1://   واریز
                    {
                        SettlemantTransaction();
                        break;
                    }
                case 2://   برداشت
                    {
                        HarvestingTransaction();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void SettlemantTransaction()
        {
            var BlanceType = (BlanceTypeCombo.SelectedItem as KeyValue<byte>).Value;
            if (BlanceType == 1)    // Cashable
            {
                CashableTransaction();
            }
            else // Banking Account
            {
                BankingTransaction();
            }

        }

        private void BankingTransaction()
        {
            try
            {
                var Cash = Convert.ToDouble(CashTxt.Text);
                var ToAccountId = (CustomerAccountCombo.SelectedItem as KeyValue<long>).Value;
                ToAccountId = _unitOfWork.CartRepository.GetCashAccountByUserId(ToAccountId).Id;
                var FromAccountID = (FromAccountCombo.SelectedItem as KeyValue<long>).Value;
                if (_unitOfWork.CartRepository.ValidBlancForTransaction(FromAccountID, Cash))
                {
                    _unitOfWork.BeginTransaction();
                    try
                    {
                        //  برداشت از حساب بانکی
                        var F_Last_Blance = _unitOfWork.BlanceRepository.GetBankingBlanceByCartId(FromAccountID);
                        var F_Blance_DTO = BlanceDTO(F_Last_Blance,Cash,FromAccountID,TransactionType.Harvesting,BlanceType.Banking);
                        _unitOfWork.BlanceRepository.DisActiveLastCashableBlanceOfCartById(FromAccountID);
                        _unitOfWork.BlanceRepository.Insert(F_Blance_DTO);
                        //  واریز به حساب نقدی
                        var T_Last_Blance = _unitOfWork.BlanceRepository.GetCashableBlanceByCartId(ToAccountId);
                        var T_Blance_DTO = BlanceDTO(T_Last_Blance,Cash,ToAccountId,TransactionType.Settlemant,BlanceType.Cashable);
                        _unitOfWork.BlanceRepository.DisActiveLastCashableBlanceOfCartById(ToAccountId);
                        _unitOfWork.BlanceRepository.Insert(T_Blance_DTO);
                        _unitOfWork.Commit();
                        ClearCloseControl();
                    }
                    catch (Exception)
                    {
                        _unitOfWork.Rollback();
                        throw;
                    }
                }
                else
                {
                    MSG.Text = MessageProject.NotEnughBlance();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CashableTransaction()
        {
            var FromCustomerID= (FromCustomerCombo.SelectedItem as KeyValue<long>).Value;
            var FromAccountID = _unitOfWork.CartRepository.GetCashAccountByUserId(FromCustomerID).Id;
            var Cash = Convert.ToDouble(CashTxt.Text);
            if (_unitOfWork.CartRepository.ValidBlancForTransaction(FromAccountID, Cash))
            {
                _unitOfWork.BeginTransaction();
                try
                {
                    var ToCustomertID = (CustomerAccountCombo.SelectedItem as KeyValue<long>).Value;
                    var ToAccountID = _unitOfWork.CartRepository.GetCashAccountByUserId(ToCustomertID).Id;
                    //  برداشت از حساب نقدی
                    var F_Last_Blance = _unitOfWork.BlanceRepository.GetCashableBlanceByCartId(FromAccountID);
                    var F_Blance_DTO = BlanceDTO(F_Last_Blance,Cash,FromAccountID,TransactionType.Harvesting,BlanceType.Cashable);
                    _unitOfWork.BlanceRepository.DisActiveLastCashableBlanceOfCartById(FromAccountID);
                    _unitOfWork.BlanceRepository.Insert(F_Blance_DTO);
                    //  واریز به حساب نقدی
                    var T_Last_Blance = _unitOfWork.BlanceRepository.GetCashableBlanceByCartId(ToAccountID);
                    var T_Blance_DTO = BlanceDTO(T_Last_Blance,Cash,ToAccountID,TransactionType.Settlemant,BlanceType.Cashable);
                    _unitOfWork.BlanceRepository.DisActiveLastCashableBlanceOfCartById(ToAccountID);
                    _unitOfWork.BlanceRepository.Insert(T_Blance_DTO);
                    _unitOfWork.Commit();
                    ClearCloseControl();
                }
                catch (Exception)
                {
                    _unitOfWork.Rollback();
                    throw;
                }
            }
            else
            {
                MSG.Text = MessageProject.NotEnughBlance();
            }

        }

        private void HarvestingTransaction()
        {
            var CustomerID = (CustomerAccountCombo.SelectedItem as KeyValue<long>).Value;
            var AccountID = (_unitOfWork.CartRepository.GetCashAccountByUserId(CustomerID)).Id;
            var Cash = Convert.ToInt64(CashTxt.Text);
            if (_unitOfWork.CartRepository.ValidBlancForTransaction(AccountID, Cash))
            {
                _unitOfWork.BeginTransaction();
                try
                {
                    var LastBlance = _unitOfWork.BlanceRepository.GetCashableBlanceByCartId(AccountID);
                    var BlanceModel = BlanceDTO(LastBlance.Value,Cash,AccountID,TransactionType.Harvesting,BlanceType.Cashable);
                    _unitOfWork.BlanceRepository.DisActiveLastCashableBlanceOfCartById(AccountID);
                    _unitOfWork.BlanceRepository.Insert(BlanceModel);
                    _unitOfWork.Commit();
                    ClearCloseControl();
                }
                catch (Exception)
                {
                    _unitOfWork.Rollback();
                    throw;
                }
            }
            else
            {
                MSG.Text = MessageProject.NotEnughBlance();
            }
        }
        #endregion

        #region SelectedIndexChanged
        private void CustomerAccountCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var CustomerId = CustomerAccountCombo.SelectedItem as KeyValue<long>;
            if (CustomerId.Value > 0)
            {
                var CartID = _unitOfWork.CartRepository.GetCashAccountByUserId(CustomerId.Value).Id;
                CACLbl.Text = _unitOfWork.BlanceRepository.GetCashableBlanceByCartId(CartID)?.ToString("N");
            }
        }
        private void FromCustomerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var CustomerId = ((KeyValue<long>)FromCustomerCombo.SelectedItem).Value;
            if (CustomerId > 0)
            {
                var CartID = _unitOfWork.CartRepository.GetCashAccountByUserId(CustomerId).Id;
                CashableBlanceLBL.Text = _unitOfWork.BlanceRepository.GetCashableBlanceByCartId(CartID).Value.ToString("N");
                FromCartCombo = ComboBoxGenerator<long>.FillData(FromCartCombo, _unitOfWork.CartRepository.TitleValueByUserID(CustomerId, BlanceType.Banking), Convert.ToByte(FromCartCombo.Tag));
            }
        }
        private void FromCartCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var CartId = ((KeyValue<long>)FromCartCombo.SelectedItem).Value;
            if (CartId != 0)
            {
                FromAccountCombo = ComboBoxGenerator<long>.FillData(FromAccountCombo, _unitOfWork.CartRepository.TitleValuesChild(CartId), Convert.ToByte(FromAccountCombo.Tag));
                FCCLbl.Text = _unitOfWork.BlanceRepository.GetBankingBlanceByCartId(CartId)?.ToString("N");
            }
        }
        private void TransactionTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var transactionType = (TransactionTypeCombo.SelectedItem as KeyValue<byte>);
            if (transactionType != null)
            {
                if (transactionType.Value == 2)   // برداشت
                {
                    SwitchTransaction(false);
                    FTLBL.Text = "از";
                }
                else    //  واریز
                {
                    FTLBL.Text = "به";
                    SwitchTransaction(true);
                }
            }
            else
            {
                FTLBL.Text = "";
                SwitchTransaction(false);
            }
            FromBankAccount(false);

        }
        private void FromAccountCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var accountID = FromAccountCombo.SelectedItem as KeyValue<long>;
            if (accountID.Value > 0)
            {
                FACLbl.Text = _unitOfWork.BlanceRepository.GetBankingBlanceByCartId(accountID.Value)?.ToString("N");
            }
        }
        #endregion

        #region ExtentionMethods
        private void FillComboBoxes()
        {
            CustomerAccountCombo = ComboBoxGenerator<long>.FillData(CustomerAccountCombo, _unitOfWork.CustomerRepository.CustomerTitleValue(), Convert.ToByte(CustomerAccountCombo.Tag));
            FromCustomerCombo = ComboBoxGenerator<long>.FillData(FromCustomerCombo, _unitOfWork.CustomerRepository.CustomerTitleValue(), Convert.ToByte(FromCustomerCombo.Tag));
            TransactionTypeCombo = ComboBoxGenerator<byte>.FillData(TransactionTypeCombo, _unitOfWork.BlanceRepository.TitleValueTransactionType(), Convert.ToByte(TransactionTypeCombo.Tag));
            BlanceTypeCombo = ComboBoxGenerator<byte>.FillData(BlanceTypeCombo, _unitOfWork.BlanceRepository.TitleValueBlanceType(), Convert.ToByte(BlanceTypeCombo.Tag));
        }
        private void SwitchTransaction(bool sw)
        {
            label7.Visible = sw;
            FromCustomerCombo.Visible = sw;
            label5.Visible = sw;
            FromCartCombo.Visible = sw;
            label6.Visible = sw;
            FromAccountCombo.Visible = sw;
            label2.Visible = sw;
            BlanceTypeCombo.Visible = sw;
        }
        private void FromBankAccount(bool sw)
        {
            label5.Visible = sw;
            FCCLbl.Visible = sw;
            FromCartCombo.Visible = sw;
            label6.Visible = sw;
            FACLbl.Visible = sw;
            FromAccountCombo.Visible = sw;
        }
        private void ClearCloseControl()
        {
            CustomerAccountCombo.Items.Clear();
            FromCustomerCombo.Items.Clear();
            FromAccountCombo.Items.Clear();
            FormExtentions.ClearRichTextBox(this.Controls);
            FormExtentions.ClearTextBoxes(this.Controls);
            FormExtentions.ClearLabel(this.Controls);
            MSG.Text = string.Empty;
            CashTxt.Text = string.Empty;
            DescTxt.Text = string.Empty;
            this.Close();
        }
        #endregion

        #region ModelDTO
        private CartDTO CartDTO(long customerId)
        {
            return new CartDTO()
            {
                CartType = Domain.Library.Enums.CartType.Main,
                CustomerID = customerId,
                Key = Guid.NewGuid(),
                AccountNumber = "",
                BankID = 0,
                ExpireDate = DateTime.Now.AddYears(5),
                ShabaAccountNumber = "",
                ParentID = null,
                Picture = "",
            };
        }
        private BlanceDTO BlanceDTO(double? lastblance, double cash, long cartId, TransactionType transaction, BlanceType blanceType)
        {
            double blanceCash = 0;
            if (lastblance > 0)
            {
                blanceCash = lastblance.Value;
                if (transaction == TransactionType.Settlemant)
                    blanceCash = lastblance.Value + cash;
                else
                    blanceCash = lastblance.Value - cash;
            }
            else
            {
                lastblance = 0;
                blanceCash = cash;
            }
            return new BlanceDTO
            {
                NewBlanceCash = blanceCash,
                OldBlanceCash = lastblance.Value,
                BlanceType = blanceType,
                CartID = cartId,
                TransactionType = transaction,
                TransactionCash = cash,
                TransactionID = TransactionID,
                Description = DescTxt.Text,
            };
        }
        #endregion


        private void BlanceTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var res = (BlanceTypeCombo.SelectedItem as KeyValue<byte>);
            if (res != null)
            {
                if (res.Value == 1)    //  نقدی
                {
                    FromBankAccount(false);
                }
                else // بانکی
                {
                    FromBankAccount(true);
                }

            }

        }

        private void CashTxt_TextChanged(object sender, EventArgs e)
        {
            if (CashTxt.Text == "" || CashTxt.Text == "0") return;
            CashTxt = InputUtilities.Thirth3Numeric(CashTxt);
        }

        private void CashTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
