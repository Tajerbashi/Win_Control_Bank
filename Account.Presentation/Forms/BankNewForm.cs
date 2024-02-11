using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Patterns;
using System.Runtime.InteropServices;

namespace Account.Presentation.Forms
{
    public partial class BankNewForm : Form
    {
        private IFacadPattern Pattern;
        private IFacadPattern _Pattern;
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
        public BankNewForm()
        {
            InitializeComponent();
            Pattern = _Pattern;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        #endregion
        private void BankNewForm_Load(object sender, EventArgs e)
        {
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Pattern.BankRepository.Insert(BankDTO());
            this.Close();

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private BankDTO BankDTO()
        {
            //  Validation
            return new BankDTO
            {
                BankName = BankNameTxt.Text,
            };
        }
    }
}
