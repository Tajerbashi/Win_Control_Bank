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
            TransactionTypeCombo = ComboBoxGenerator.FillData(TransactionTypeCombo, unitOfWork.TransactionService.TitleValueKind(), Convert.ToByte(TransactionTypeCombo.Tag));
            TransactionKindCombo = ComboBoxGenerator.FillData(TransactionKindCombo, unitOfWork.TransactionService.TitleValue(), Convert.ToByte(TransactionKindCombo.Tag));

            FromCustomerCombo = ComboBoxGenerator.FillData(FromCustomerCombo, unitOfWork.CartService.TitleValue(), Convert.ToByte(FromCustomerCombo.Tag));
            ToCustomerCombo = ComboBoxGenerator.FillData(ToCustomerCombo, unitOfWork.CartService.TitleValue(), Convert.ToByte(ToCustomerCombo.Tag));

            BlanceTypeCombo = ComboBoxGenerator.FillData(BlanceTypeCombo, unitOfWork.BlanceService.TitleValue(), Convert.ToByte(BlanceTypeCombo.Tag));
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
                        label5.Visible = false;
                        ToCustomerCombo.Visible = false;
                        label7.Visible = false;
                        ToAccountCombo.Visible = false;
                        TransactionKindCombo.SelectedIndex = 2;
                        break;
                    }
                case 2:
                    {
                        label5.Visible = false;
                        ToCustomerCombo.Visible = false;
                        label7.Visible = false;
                        ToAccountCombo.Visible = false;
                        TransactionKindCombo.SelectedIndex = 2;
                        break;
                    }
                case 3:
                    {
                        label5.Visible = true;
                        ToCustomerCombo.Visible = true;
                        label7.Visible = true;
                        ToAccountCombo.Visible = true;
                        TransactionKindCombo.SelectedIndex = 2;
                        break;
                    }
                case 4:
                    {
                        label5.Visible = false;
                        ToCustomerCombo.Visible = false;
                        label7.Visible = false;
                        ToAccountCombo.Visible = false;
                        TransactionKindCombo.SelectedIndex = 1;
                        break;
                    }
                default:
                    {
                        MSG.Text = "هنوز هیچ نوع تراکنشی تایید نشده است";
                        label5.Visible = false;
                        ToCustomerCombo.Visible = false;
                        label7.Visible = false;
                        ToAccountCombo.Visible = false;
                        break;
                    }
            }
        }

        private void NewUserCheck_CheckedChanged(object sender, EventArgs e)
        {
            //if (NewUserCheck.Checked)
            //{
            //    PanelNewUser.Visible = true;
            //}
            //else
            //{
            //    PanelNewUser.Visible = false;
            //}
        }

        private void CustomerCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            var Id = ((KeyValue<long>)FromCustomerCombo.SelectedItem).Value; ;
            if (Id != 0)
            {
                FromAccountCombo = ComboBoxGenerator.FillData(FromAccountCombo, unitOfWork.CartService.TitleValuesChild(Id), Convert.ToByte(FromAccountCombo.Tag));
            }
            //FromCartCombo = ComboBoxGenerator.FillData(FromCartCombo, unitOfWork.CartService.TitleValue(), Convert.ToByte(TransactionTypeCombo.Tag));
            //FromCartCombo = ComboBoxGenerator.FillData(FromCartCombo, unitOfWork.CartService.TitleValueByUser(((KeyValue<long>)CustomerCombo.SelectedItem).Value), Convert.ToByte(TransactionTypeCombo.Tag));
        }

        private void ToCustomerCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            var Id = ((KeyValue<long>)ToCustomerCombo.SelectedItem).Value; ;
            if (Id != 0)
            {
                ToAccountCombo = ComboBoxGenerator.FillData(ToAccountCombo, unitOfWork.CartService.TitleValuesChild(Id), Convert.ToByte(ToAccountCombo.Tag));
            }
        }
    }
}
