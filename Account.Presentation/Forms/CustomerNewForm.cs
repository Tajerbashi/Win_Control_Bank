using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Repositories.BUS;
using Account.Presentation.Extentions;
using Presentation.Extentions;
using System.Runtime.InteropServices;

namespace Account.Presentation.Forms
{
    public partial class CustomerNewForm : Form
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
        private readonly ICustomerRepository _customerRepository;
        public CustomerNewForm(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            MSG.Text = "";
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        OpenFileDialog ofd = new OpenFileDialog();
        Image pic;
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFormData();
        }

        private CustomerDTO CustomerDTO()
        {
            return new CustomerDTO
            {
                Key = Guid.NewGuid(),
                FullName = FullNameTxt.Text,
                Picture = FileHandler.SavePic(FullNameTxt.Text, ofd),
            };
        }

        private void FullNameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SaveFormData();
            }
        }

        private void SaveFormData()
        {
            var customer = CustomerDTO();
            _customerRepository.Insert(customer);
            MSG.Visible = true;
            MSG.Text = "عملیات با موفقیت انجام شد";
            FormExtentions.ClearTextBoxes(this.Controls);
            UserPicture.Image = null;
            this.Close();
            MSG.Text = "";

        }

        private void UserPicture_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPG(*.JPG)|*.JPG";
            ofd.Title = "تصویر کاربر را انتخاب کنید";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic = Image.FromFile(ofd.FileName);
                UserPicture.Image = pic;
                UserPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
