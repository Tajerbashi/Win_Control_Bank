using Infrastructure.Library.Models.Controls;
using Infrastructure.Library.Patterns;
using Presentation.Generator;
using System.Runtime.InteropServices;

namespace Presentation.Forms
{
    public partial class TransactionNewForm : Form
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
        public TransactionNewForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }
        private void timer_Tick(object sender, EventArgs e)
        {
        }

        #endregion

        private IUnitOfWork _unitOfWork;
        private IUnitOfWork unitOfWork
        {
            get => _unitOfWork = _unitOfWork ?? new UnitOfWork();
        }


        private void TransactionNewForm_Load(object sender, EventArgs e)
        {
            TransactionTypeCombo = ComboBoxGenerator.FillData(TransactionTypeCombo, unitOfWork.TransactionService.TitleValue(), Convert.ToByte(TransactionTypeCombo.Tag));
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var type = ((KeyValue<long>)TransactionTypeCombo.SelectedItem).Value;
            switch (type)
            {
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                default:
                    {
                        MSG.Text = "هنوز هیچ نوع تراکنشی تایید نشده است";
                        break;
                    }
            }
        }

        private void TransactionTypeCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            var type = ((KeyValue<long>)TransactionTypeCombo.SelectedItem).Value;
            MSG.Text = type.ToString();
            switch (type)
            {
                case 1:
                    {
                        PanelType1.Visible = true;
                        PanelType2.Visible = false;
                        PanelType3.Visible = false;
                        PanelType4.Visible = false;
                        break;
                    }
                case 2:
                    {
                        PanelType1.Visible = false;
                        PanelType2.Visible = true;
                        PanelType3.Visible = false;
                        PanelType4.Visible = false;
                        break;
                    }
                case 3:
                    {
                        PanelType1.Visible = false;
                        PanelType2.Visible = false;
                        PanelType3.Visible = true;
                        PanelType4.Visible = false;
                        break;
                    }
                case 4:
                    {
                        PanelType1.Visible = false;
                        PanelType2.Visible = false;
                        PanelType3.Visible = false;
                        PanelType4.Visible = true;
                        break;
                    }
                default:
                    {
                        MSG.Text = "هنوز هیچ نوع تراکنشی تایید نشده است";
                        PanelType1.Visible = false;
                        PanelType2.Visible = false;
                        PanelType3.Visible = false;
                        PanelType4.Visible = false;
                        break;
                    }
            }
        }
    }
}
