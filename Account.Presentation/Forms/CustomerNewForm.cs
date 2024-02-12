using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Patterns;
using Presentation.Extentions;

namespace Account.Presentation.Forms
{
    public partial class CustomerNewForm : Form
    {
        private IFacadPattern Pattern;

        public CustomerNewForm()
        {
            InitializeComponent();
            //Pattern = new FacadPattern();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        Image pic;
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var customer = CustomerDTO();
            Pattern.CustomerRepository.Insert(customer);
            MSG.Visible = true;
            MSG.Text = "عملیات با موفقیت انجام شد";
            this.Close();
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

        private void UserPicture_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
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
}
