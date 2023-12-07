using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Library.Patterns;

namespace Presentation.Forms
{
    public partial class UserNewForm : Form
    {
        private readonly IUnitOfWork _unitOfWork = new UnitOfWork();
        public UserNewForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        System.Windows.Forms.Timer Timer =new System.Windows.Forms.Timer();

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            CustomerDTO customer = new CustomerDTO();
            customer.FullName = FullNameTxt.Text;
            customer.Title = TitleTxt.Text;
            customer.Description = DescriptionTxt.Text;
            customer.Key = Guid.NewGuid();
            _unitOfWork.CustomerService.Insert(customer);
            _unitOfWork.CustomerService.Save();
            Timer.Tick += new EventHandler(timer1_Tick);
            Timer.Interval = 3000;
            Timer.Start();
            MSG.Visible = true;
            MSG.Text = "عملیات با موفقیت انجام شد";
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MSG.Visible = false;
            Timer.Stop();
        }
    }
}
