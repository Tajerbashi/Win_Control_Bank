using Infrastructure.Library.Models.DTOs.BUS;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Atf.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Infrastructure.Library.Patterns;
using Presentation.Generator;
using Infrastructure.Library.Models.Controls;
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

            try
            {
                unitOfWork.BeginTransaction();
                CartDTO model = new CartDTO();
                BlanceDTO blance = new BlanceDTO();
                model.AccountNumber = AccountNumberTxt.Text;
                model.Key = Guid.NewGuid();
                model.ShabaAccountNumber = ShabaCartNumber.Text;
                model.BankID = BankCombo.SelectedIndex;
                model.CustomerID = ((KeyValue<long>)CustomerCombo.SelectedItem).Value;
                model.BankID = ((KeyValue<long>)BankCombo.SelectedItem).Value;
                model.ExpireDate = (DateTime)ExpireDate.Value;
                var Cart = unitOfWork.CartService.Insert(model);
                blance.CartID = (long)Cart;
                blance.LastCash = Convert.ToDouble(BlanceTxt.Text);
                blance.Cash = Convert.ToDouble(BlanceTxt.Text);
                unitOfWork.BlanceService.Insert(blance);
                unitOfWork.CommitTransaction();
                this.Close();
            }
            catch (Exception)
            {
                unitOfWork.RollBackTransaction();
                throw;
            }
            
        }

        private void CartNewForm_Load(object sender, EventArgs e)
        {
            BankCombo = ComboBoxGenerator.FillData(BankCombo,unitOfWork.BankService.TitleValue(), Convert.ToByte(BankCombo.Tag));
            CustomerCombo = ComboBoxGenerator.FillData(CustomerCombo,unitOfWork.CustomerService.TitleValue(), Convert.ToByte(CustomerCombo.Tag));
            ExpireDate.UsePersianFormat = true;
            ExpireDate.Value = DateTime.Now;
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
    }
}
