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
    public partial class CustomerPanel : UserControl
    {
        public CustomerPanel()
        {
            InitializeComponent();
        }
        CRUD crud = new CRUD();
        MainForm M = new MainForm();
        NiceStoreDBEntities DB = new NiceStoreDBEntities();
        int ID = -1;
        bool SW = true;
        public void PrintDGV1()
        {
            DGV1.Rows.Clear();
            var db = (from i in DB.CustomerTBs select i);
            foreach (var item in db)
            {
                DGV1.Rows.Add(item.id,item.Name,item.Phone);
            }
        }
        public void ShowResultSearch(String Word)
        {
            DGV1.Rows.Clear();
            var db = (from i in DB.CustomerTBs orderby i.Name ascending where (i.Name).Contains(Word) || (i.Phone).Contains(Word) select i).ToList();
            foreach (var item in db)
            {
                DGV1.Rows.Add(item.id, item.Name, item.Phone);
            }
        }
        public void ShowAcsSort()
        {
            DGV1.Rows.Clear();
            var db = (from i in DB.CustomerTBs orderby i.Name ascending select i);
            foreach (var item in db)
            {
                DGV1.Rows.Add(item.id, item.Name, item.Phone);
            }
        }
        
        private void AddCuBtn_Click(object sender, EventArgs e)
        {
            if ( CuNametxt.Text.Trim().Length == 0 )
            {
                MessageBox.Show("نام مشتری را وارد کنید");
                CuNametxt.Focus();
            }
            else if ( CuPhonetxt.Text.Trim().Length == 0 )
            {
                MessageBox.Show("شماره تماس مشتری را وارد کنید");
                CuPhonetxt.Focus();
            }
            else
            {
                CustomerTB customer = new CustomerTB();
                customer.id = ID;
                customer.Name =  CuNametxt.Text;
                customer.Phone = M.ChangeToEnglishNumber(CuPhonetxt.Text);

                if (SW)
                {
                    if (crud.CreatCustomer(customer))
                    {
                        MessageBox.Show("ثبت نام با موفقیت انجام شد");
                        PrintDGV1();
                        M.ClearTextBoxes(this.Controls);
                    }
                    else
                    {
                        MessageBox.Show("ثبت نام انجام نشد");
                    }
                }
                else
                {
                    if (crud.EditCustomer(customer))
                    {
                        DGV1.Rows.Clear();
                        this.Refresh();
                        MessageBox.Show("ویرایش شد");
                        PrintDGV1();
                        M.ClearTextBoxes(this.Controls);
                        AddCuBtn.Text = "ذخیره";
                        SW = true;
                    }
                    else
                    {
                        MessageBox.Show("اطلاعات تکراری است");
                    }
                }
            }
            
            
        }

        private void CustomerPanel_Load(object sender, EventArgs e)
        {
            PrintDGV1();
        }

        private void DGV1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                DGV1.CurrentRow.Selected = (DGV1.CurrentRow.Selected) ? false : true;
                ID = int.Parse(DGV1.CurrentRow.Cells[0].Value.ToString());
            }
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuNametxt.Text = DGV1.CurrentRow.Cells[1].Value.ToString();
            CuPhonetxt.Text = DGV1.CurrentRow.Cells[2].Value.ToString();
            AddCuBtn.Text = "بروزرسانی";
            SW = false;
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == (MessageBox.Show("آیا میخواهید مشتری حذف شود؟", "تایید درخواست", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)))
            {
                crud.DeleteCustomer(ID);
                MessageBox.Show("مشتری حذف شد");
            }
            
        }

        private void CuSearchbtn_Click(object sender, EventArgs e)
        {
            ShowResultSearch(CuSearchtxt.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowAcsSort();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PrintDGV1();
        }
    }
}
