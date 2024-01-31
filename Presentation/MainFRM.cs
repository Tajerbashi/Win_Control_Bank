using Common.Library.Utilities;
using Microsoft.Extensions.Logging;
using Presentation.Extentions;
using Presentation.UserControls;
using System.Runtime.InteropServices;

namespace Presentation
{
    public partial class MainFRM : Form
    {
        LoggerProvider<MainFRM> loggerProvider = new LoggerProvider<MainFRM>();
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
        public MainFRM()
        {
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

        #endregion

        private void MainFRM_Load(object sender, EventArgs e)
        {
            loggerProvider.InfoLog($"شروع نرم افزار  {DateTimeUtility.ToPersionFormat(DateTime.Now)}");
            OnlineExchangeUC panel = new OnlineExchangeUC();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            MainPanel.Controls.Add(panel);
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CartBtn_Click(object sender, EventArgs e)
        {
            CartUC panel = new CartUC();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            MainPanel.Controls.Add(panel);
        }

        private void UserBtn_Click(object sender, EventArgs e)
        {
            CustomerUS panel = new CustomerUS();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            MainPanel.Controls.Add(panel);

        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            ReportUC panel = new ReportUC();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            MainPanel.Controls.Add(panel);
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            CalculateUC panel = new CalculateUC();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            MainPanel.Controls.Add(panel);
        }

        private void CashMoneyBtn_Click(object sender, EventArgs e)
        {
            CashMoneyUC panel = new CashMoneyUC();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            MainPanel.Controls.Add(panel);
        }

        private void TaransactionBtn_Click(object sender, EventArgs e)
        {
            TransactionUC panel = new TransactionUC();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            MainPanel.Controls.Add(panel);
        }

        private void OnlineExchangeBtn_Click(object sender, EventArgs e)
        {
            OnlineExchangeUC panel = new OnlineExchangeUC();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
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
            BankUC panel = new BankUC();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            MainPanel.Controls.Add(panel);
        }


        private void BalanceBtn_Click(object sender, EventArgs e)
        {
            BlanceUC panel = new BlanceUC();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            MainPanel.Controls.Add(panel);
        }

        private void MainFRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            loggerProvider.InfoLog($"بستن نرم افزار  {DateTimeUtility.ToPersionFormat(DateTime.Now)}");
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            SettingUC panel = new SettingUC();
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[0].Dispose();
            }
            MainPanel.Controls.Add(panel);
        }
    }
}
