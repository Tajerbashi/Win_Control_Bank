using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Patterns;
using Account.Domain.Library.Enums;
using Account.Presentation.Generator;
using System.Runtime.InteropServices;

namespace Account.Presentation.Forms
{
    public partial class CashableBlanceForm : Form
    {
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
            var CustomerId = ((KeyValue<long>)CustomerAccountCombo.SelectedItem).Value;
            var CashableCartId = 0;


            if (CashableCartId > 0)
            {
                //  Exist Cashable Blance
            }
            else
            {
                //  Create Cashable Blance
            }
        }
        #endregion

        #region SelectedIndexChanged
        private void CustomerAccountCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var accountID = CustomerAccountCombo.SelectedItem as KeyValue<long>;
            if (accountID.Value > 0)
            {
                CACLbl.Text = _unitOfWork.BlanceRepository.GetCashableBlanceByCartId(accountID.Value)?.ToString("N");
            }
        }
        private void FromCustomerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var CustomerId = ((KeyValue<long>)FromCustomerCombo.SelectedItem).Value;
            if (CustomerId > 0)
            {
                FromCartCombo = ComboBoxGenerator<long>.FillData(FromCartCombo, _unitOfWork.CartRepository.TitleValueByUserID(CustomerId), Convert.ToByte(FromCartCombo.Tag));
            }
        }
        private void FromCartCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var CartId = ((KeyValue<long>)FromCartCombo.SelectedItem).Value;
            if (CartId != 0)
            {
                FCCLbl.Text = _unitOfWork.BlanceRepository.GetBankingBlanceByCartId(CartId)?.ToString("N");
                FromAccountCombo = ComboBoxGenerator<long>.FillData(FromAccountCombo, _unitOfWork.CartRepository.TitleValuesChild(CartId), Convert.ToByte(FromAccountCombo.Tag));
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
                }
                else    //  واریز
                {
                    SwitchTransaction(true);
                }
            }
            else
            {
                SwitchTransaction(false);
            }

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
            FromCustomerCombo = ComboBoxGenerator<long>.FillData(FromCustomerCombo, _unitOfWork.CustomerRepository.CustomerTitleValue(), Convert.ToByte(FromCustomerCombo.Tag));
            CustomerAccountCombo = ComboBoxGenerator<long>.FillData(CustomerAccountCombo, _unitOfWork.CustomerRepository.CustomerTitleValue(), Convert.ToByte(CustomerAccountCombo.Tag));
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
        #endregion


    }
}
