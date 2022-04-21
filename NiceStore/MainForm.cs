using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.Entity;
namespace NiceStore
{
    public partial class MainForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRecRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRecRgn(0,0,Width,Height,15,15));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CustomerPanel panel = new CustomerPanel();
            if (panel2.Controls.Count > 0)
            {
                panel2.Controls[0].Dispose();
            }
            panel2.Controls.Add(panel);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CustomerPanel panel = new CustomerPanel();
            if (panel2.Controls.Count > 0)
            {
                panel2.Controls[0].Dispose();
            }
            panel2.Controls.Add(panel);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ProductPanel panel = new ProductPanel();
            if (panel2.Controls.Count > 0)
            {
                panel2.Controls[0].Dispose();
            }
            panel2.Controls.Add(panel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StoreManagmentPanel panel = new StoreManagmentPanel();
            if (panel2.Controls.Count > 0)
            {
                panel2.Controls[0].Dispose();
            }
            panel2.Controls.Add(panel);
        }
    }
}
