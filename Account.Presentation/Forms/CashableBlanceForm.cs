using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Patterns;
using Account.Application.Library.Repositories.BUS;
using Account.Domain.Library.Enums;
using Account.Presentation.Generator;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Account.Presentation.Forms
{
    public partial class CashableBlanceForm : Form
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IBankRepository _bankRepository;
        private readonly IBlanceRepository _blanceRepository;
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
        #endregion

        public CashableBlanceForm(
            ICustomerRepository customerRepository,
            IBankRepository bankRepository,
            IBlanceRepository blanceRepository,
            IUnitOfWork unitOfWork
            )
        {
            _customerRepository = customerRepository;
            _bankRepository = bankRepository;
            _blanceRepository = blanceRepository;
            _unitOfWork = unitOfWork;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void FillComboBoxes()
        {
            CustomerAccountCombo = ComboBoxGenerator<long>.FillData(CustomerAccountCombo, _unitOfWork.CustomerRepository.TitleValue(), Convert.ToByte(CustomerAccountCombo.Tag));
            FromCustomerCombo = ComboBoxGenerator<long>.FillData(FromCustomerCombo, _unitOfWork.CustomerRepository.TitleValue(), Convert.ToByte(FromCustomerCombo.Tag));
            TransactionTypeCombo = ComboBoxGenerator<byte>.FillData(TransactionTypeCombo, _unitOfWork.BlanceRepository.TitleValueTransactionType(), Convert.ToByte(TransactionTypeCombo.Tag));
            BlanceTypeCombo = ComboBoxGenerator<byte>.FillData(BlanceTypeCombo, _unitOfWork.BlanceRepository.TitleValueBlanceType(), Convert.ToByte(BlanceTypeCombo.Tag));
            ActionTypeCombo = ComboBoxGenerator<byte>.FillData(ActionTypeCombo, _unitOfWork.BlanceRepository.TitleValueBlanceType(), Convert.ToByte(ActionTypeCombo.Tag));
            BlanceTypeCombo.SelectedIndex = 1;
            //UnitCombo = ComboBoxGenerator<long>.FillData(UnitCombo, _unitOfWork.CartRepository.TitleValue(), Convert.ToByte(UnitCombo.Tag));
        }

        private void CashableBlanceForm_Load(object sender, EventArgs e)
        {
            FillComboBoxes();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var CustomerId = ((KeyValue<long>)CustomerAccountCombo.SelectedItem).Value;
            var CashableCartId = _unitOfWork.CartRepository.GetCashableCartByCustomerId(CustomerId);


            if (CashableCartId > 0)
            {
                //  Exist Cashable Blance
            }
            else
            {
                //  Create Cashable Blance
            }
        }



        private void CustomerAccountCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

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

        private void FromCustomerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var CustomerId = ((KeyValue<long>)FromCustomerCombo.SelectedItem).Value;
            if (CustomerId > 0)
            {
                FromCartCombo = ComboBoxGenerator<long>.FillData(FromCartCombo, _unitOfWork.CartRepository.TitleValueByUser(CustomerId), Convert.ToByte(FromCartCombo.Tag));
            }
        }
        private void FromCartCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var CartId = ((KeyValue<long>)FromCartCombo.SelectedItem).Value;
            if (CartId != 0)
            {
                FromAccountCombo = ComboBoxGenerator<long>.FillData(
                    FromAccountCombo,
                    _unitOfWork.CartRepository.TitleValuesCartsByCartIdAboutCustomer(CartId),
                    Convert.ToByte(FromAccountCombo.Tag));
            }
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
    }
}
