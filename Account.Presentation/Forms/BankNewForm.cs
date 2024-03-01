using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Repositories.BUS;
using Account.Presentation.Extentions;
using FluentValidation;
using FluentValidation.Results;
using System.Runtime.InteropServices;

namespace Account.Presentation.Forms
{
    public partial class BankNewForm : Form
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
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        System.Windows.Forms.Timer Timer =new System.Windows.Forms.Timer();
        #endregion
        private readonly IBankRepository _bankRepository;
        private IValidator<BankDTO> _bankValidator;
        public BankNewForm(IBankRepository bankRepository, IValidator<BankDTO> bankValidator)
        {
            _bankRepository = bankRepository;
            _bankValidator = bankValidator;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void BankNewForm_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            ValidationResult result = _bankValidator.Validate(BankDTO());
            if (!result.IsValid)
            {
                MSG.Visible = true;
                MSG.Text = result.Errors.Select(x => ($"{x.ErrorMessage} : {x.AttemptedValue}")).FirstOrDefault();
                return;
            }
            _bankRepository.Insert(BankDTO());
            FormExtentions.ClearTextBoxes(this.Controls);
            MSG.Text = "";
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

        private void BankNameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveBtn_Click(sender, e);
            }
        }
    }
}
