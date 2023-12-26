using Domain.Library.Enums;
using Infrastructure.Library.Models.Controls;
using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Library.Patterns;
using Presentation.Generator;
using System.Runtime.InteropServices;
namespace Presentation.Forms
{
    public partial class CartNewForm : Form
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IFacadPattern pattern;
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
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        System.Windows.Forms.Timer Timer =new System.Windows.Forms.Timer();
        public CartNewForm()
        {
            unitOfWork = new UnitOfWork();
            pattern = new FacadPattern();
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        #endregion


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using (var context = unitOfWork.BeginTransaction())
            {
                try
                {
                    CartDTO cart = new CartDTO();
                    TransactionDTO transaction = new TransactionDTO();
                    BlanceDTO blance = new BlanceDTO();
                    cart.Key = Guid.NewGuid();
                    cart.ShabaAccountNumber = ShabaCartNumber.Text;
                    cart.BankID = BankCombo.SelectedIndex;
                    cart.CustomerID = ((KeyValue<long>)CustomerCombo.SelectedItem).Value;
                    cart.ParentID = ((KeyValue<long>)ParentCartCombo.SelectedItem).Value == 0 ? null : ((KeyValue<long>)ParentCartCombo.SelectedItem).Value;
                    if (cart.ParentID != null)
                    {
                        cart.AccountNumber = $"{AccountNumberTxt.Text} : {cart.ParentID}";
                    }
                    else
                    {
                        cart.AccountNumber = $"{AccountNumberTxt.Text}";
                    }
                    cart.BankID = ((KeyValue<long>)BankCombo.SelectedItem).Value;
                    cart.ExpireDate = (DateTime)ExpireDate.Value;
                    var cartId = unitOfWork.CartService.Insert(cart);
                    transaction.Cash = Convert.ToDouble(BlanceTxt.Text);
                    transaction.TransactionType = TransactionType.Settlemant;
                    transaction.CartID = (long)cartId;
                    var tracId = unitOfWork.TransactionService.Insert(transaction);
                    blance.BlanceCash = Convert.ToDouble(BlanceTxt.Text);
                    blance.BlanceType = BlanceType.Banking;
                    blance.TransactionID = (long)tracId;
                    unitOfWork.BlanceService.Insert(blance);
                    context.Commit();
                    this.Close();
                }
                catch (Exception)
                {
                    context.Rollback();
                    throw;
                }
            }

        }

        private void CartNewForm_Load(object sender, EventArgs e)
        {
            BankCombo = ComboBoxGenerator.FillData(BankCombo, unitOfWork.BankService.TitleValue(), Convert.ToByte(BankCombo.Tag));
            CustomerCombo = ComboBoxGenerator.FillData(CustomerCombo, unitOfWork.CustomerService.TitleValue(), Convert.ToByte(CustomerCombo.Tag));
            ExpireDate.UsePersianFormat = true;
            ExpireDate.Value = DateTime.Now;
            unitOfWork.Dispose();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BlanceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void AccountNumberTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ShabaCartNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ParentCartCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var PId =  ((KeyValue<long>)ParentCartCombo.SelectedItem).Value;
            AccountNumberTxt.Text = string.Empty;
            AccountNumberTxt.Enabled = true;
            ShabaCartNumber.Text = string.Empty;
            ShabaCartNumber.Enabled = true;
            ExpireDate.Value = DateTime.Now;
            ShabaCartNumber.Enabled = true;
            if (PId != 0)
            {
                var cartModel = unitOfWork.CartService.GetById(PId);
                AccountNumberTxt.Text = cartModel.AccountNumber;
                AccountNumberTxt.Enabled = false;
                ShabaCartNumber.Text = cartModel.ShabaAccountNumber;
                ShabaCartNumber.Enabled = false;
                ExpireDate.Value = cartModel.ExpireDate;
                ExpireDate.Enabled = false;
            }
        }

        private void BankCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Id = ((KeyValue<long>)BankCombo.SelectedItem).Value;
            if (Id != 0)
            {
                ParentCartCombo = ComboBoxGenerator.FillData(ParentCartCombo, unitOfWork.CartService.TitleValuesCartByBankId(Id), Convert.ToByte(ParentCartCombo.Tag));
            }
            else
            {
                ParentCartCombo.Items.Clear();
            }
        }
    }
}
