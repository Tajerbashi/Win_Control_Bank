using Infrastructure.Library.Services.SEC;
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
    public partial class UserUS : UserControl
    {
        public UserUS()
        {
            InitializeComponent();
        }
        protected void ShowDataGrid()
        {
            UserService userService = new UserService();
            var users = userService.GetAll();
            GridData.DataSource = users;
        }

        private void UserUS_Load(object sender, EventArgs e)
        {
            ShowDataGrid();
        }
    }
}
