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
using System.Diagnostics;

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
        #region Functions
        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }
        public String ChangeToEnglishNumber(String text)
        {
            var englishNumbers = String.Empty;
            for (var i = 0; i < text.Length; i++)
            {
                if (char.IsNumber(text[i])) englishNumbers += char.GetNumericValue(text, i);
                else englishNumbers += text[i];
            }

            return englishNumbers;
        }
        #endregion
        NiceStoreDBEntities DB = new NiceStoreDBEntities();
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/kamran_tajerbashi/");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
