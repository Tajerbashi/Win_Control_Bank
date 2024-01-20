using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Library.Patterns;

namespace Presentation.Forms
{
    public partial class CustomerNewForm : Form
    {
        private IFacadPattern Pattern;

        public CustomerNewForm()
        {
            InitializeComponent();
            Pattern = new FacadPattern();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var customer = CustomerDTO();
            Pattern.CustomerService.Insert(customer);
            MSG.Visible = true;
            MSG.Text = "عملیات با موفقیت انجام شد";
            this.Close();
        }

        private CustomerDTO CustomerDTO()
        {
            return new CustomerDTO
            {
                Description = DescriptionTxt.Text,
                Key = Guid.NewGuid(),
                FullName = FullNameTxt.Text,
                Picture = "",
                Title = TitleTxt.Text,
            };
        }
    }
}
