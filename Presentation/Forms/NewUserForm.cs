using Domain.Library.Entities.BUS;
using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Library.Services.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class NewUserForm : Form
    {
        public NewUserForm()
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
            CustomerService customerService = new CustomerService();
            customerService.Insert(customer);
            customerService.Save();
            Timer.Tick += new EventHandler(timer1_Tick);
            Timer.Interval = 3000;
            Timer.Start();
            MSG.Visible = true;
            MSG.Text = "عملیات با موفقیت انجام شد";
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MSG.Visible = false;
            Timer.Stop();
        }
    }
}
