using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NiceStore
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            MainForm MF = new MainForm();
            this.Hide();
            MF.Show();
        }

        private void SplashForm_Shown(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
