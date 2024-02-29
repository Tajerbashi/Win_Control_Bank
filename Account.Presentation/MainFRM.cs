using Account.Application.Library.Repositories.SEC;
using Account.Common.Library.Utilities;
using Account.Presentation.Extentions;
using Account.Presentation.Forms;
using Account.Presentation.UserControls;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Presentation
{

    public partial class MainFRM : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly LoggerProvider _loggerProvider;
        private BankUC _bankUC;
        private CartUC _cartUC;
        private CustomerUC _customerUC;
        private ReportUC _reportUC;
        private CalculateUC _calculateUC;
        private CashMoneyUC _cashMoneyUC;
        private TransactionUC _transactionUC;
        private SettlemantUC _settlemantUC;
        private SettingUC _settingUC;
        private BlanceUC _blanceUC;
        private TransactionNewForm _transactionForm;

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

        public MainFRM(
            IUserRepository userRepository,
            LoggerProvider loggerProvider,
            BankUC bankUC,
            CartUC cartUC,
            CustomerUC customerUC,
            ReportUC reportUC,
            CalculateUC calculateUC,
            CashMoneyUC cashMoneyUC,
            TransactionUC transactionUC,
            SettlemantUC settlemantUC,
            SettingUC settingUC,
            BlanceUC blanceUC,
            TransactionNewForm transactionForm
            )
        {
            _userRepository = userRepository;
            _loggerProvider = loggerProvider;
            _bankUC = bankUC;
            _cartUC = cartUC;
            _customerUC = customerUC;
            _reportUC = reportUC;
            _calculateUC = calculateUC;
            _cashMoneyUC = cashMoneyUC;
            _transactionUC = transactionUC;
            _settlemantUC = settlemantUC;
            _settingUC = settingUC;
            _blanceUC = blanceUC;
            _transactionForm = transactionForm;
            _loggerProvider.Log.Info($"ساعت ورود کاربر ادمین : {DateTimeUtility.ToPersionFormat(DateTime.Now)}");
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Timer.Tick += new EventHandler(timer_Tick);
            Timer.Interval = 500;
            Timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            ClockLbl.Text = DateUtilities.PersianDate();//zaman ro mide
        }


        private void MainFRM_Load(object sender, EventArgs e)
        {
            OnlineExchangeUC panel = new OnlineExchangeUC();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls.Clear();
            }
            MainPanel.Controls.Add(panel);
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CartBtn_Click(object sender, EventArgs e)
        {
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls.Clear();
            }
            MainPanel.Controls.Add(_cartUC);
        }

        private void UserBtn_Click(object sender, EventArgs e)
        {
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls.Clear();
            }
            MainPanel.Controls.Add(_customerUC);
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls.Clear();
            }
            MainPanel.Controls.Add(_reportUC);
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls.Clear();
            }
            MainPanel.Controls.Add(_calculateUC);
        }

        private void CashMoneyBtn_Click(object sender, EventArgs e)
        {
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls.Clear();
            }
            MainPanel.Controls.Add(_cashMoneyUC);
        }

        private void TaransactionBtn_Click(object sender, EventArgs e)
        {
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls.Clear();
            }
            MainPanel.Controls.Add(_transactionUC);
        }

        private void OnlineExchangeBtn_Click(object sender, EventArgs e)
        {
            OnlineExchangeUC panel = new OnlineExchangeUC();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls.Clear();
            }
            MainPanel.Controls.Add(panel);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BankBtn_Click(object sender, EventArgs e)
        {
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls.Clear();
            }
            MainPanel.Controls.Add(_bankUC);
        }


        private void BalanceBtn_Click(object sender, EventArgs e)
        {
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls.Clear();
            }
            MainPanel.Controls.Add(_blanceUC);
        }

        private void MainFRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loggerProvider.Log.Info($"ساعت خروج کاربر ادمین : {DateTimeUtility.ToPersionFormat(DateTime.Now)}");
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls.Clear();
            }
            MainPanel.Controls.Add(_settingUC);
        }

        private void NewTransactionBtn_Click(object sender, EventArgs e)
        {
            _transactionForm.ShowDialog();
        }

        private void SettlemantBtn_Click(object sender, EventArgs e)
        {
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls.Clear();
            }
            MainPanel.Controls.Add(_settlemantUC);
        }
    }
}
