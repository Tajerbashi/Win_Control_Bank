using Infrastructure.Library.Services.BUS;
using Infrastructure.Library.Services.SEC;
using Presentation.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.UserControls
{
    public partial class CustomerUS : UserControl
    {
        public CustomerUS()
        {
            InitializeComponent();
        }
        private void ShowDataGrid()
        {
            CustomerService customerService = new CustomerService();
            var users = customerService.GetAll();
            GridData.DataSource = users;
        }

        private void UserUS_Load(object sender, EventArgs e)
        {
            ShowDataGrid();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            NewUserForm form = new NewUserForm();
            form.ShowDialog();
            ShowDataGrid();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
