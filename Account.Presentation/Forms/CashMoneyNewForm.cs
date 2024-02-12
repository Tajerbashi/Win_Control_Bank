using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Patterns;
using Account.Application.Library.Repositories.RPT;
using Account.Presentation.Generator;
using System.Runtime.InteropServices;

namespace Account.Presentation.Forms
{
    public partial class CashMoneyNewForm : Form
    {

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
        #endregion
        private readonly ICartReportRepository _cartReportRepository;

        public CashMoneyNewForm(
            ICartReportRepository cartReportRepository
            )
        {
            _cartReportRepository = cartReportRepository;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void CashMoneyNewForm_Load(object sender, EventArgs e)
        {
            AccountCombo = ComboBoxGenerator<long>.FillData(AccountCombo, _cartReportRepository.TitleValue(), Convert.ToByte(AccountCombo.Tag));

        }

        private void CashTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            BlanceDTO blanceDTO = new BlanceDTO();

        }
    }
}
