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
    public partial class ProductPanel : UserControl
    {
        public ProductPanel()
        {
            InitializeComponent();
        }
        CRUD crud = new CRUD();
        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxEx1.SelectedIndex == 0)
            {
                ToolsBox.Enabled = false;
                PhoneBox.Enabled = true;
            }
            else
            {
                ToolsBox.Enabled = true;
                PhoneBox.Enabled = false;
            }
        }

        private void AddProductbtn_Click(object sender, EventArgs e)
        {
            if (PhoneBox.Enabled)
            {
                PhoneTB phone = new PhoneTB();
                phone.Barcode = int.Parse(barcode.Text);
                phone.Name = name.Text;
                phone.Price = int.Parse(price.Text);
                phone.Mojod = int.Parse(mojodi.Value.ToString());
                phone.Brand = brand.Text;
                phone.CPU = Int16.Parse(cpu.Text);
                phone.ScreenSize = screensize.Text;
                phone.RAM = Int16.Parse( RAM.Value.ToString());
                if (crud.CreatPhone(phone))
                {
                    MessageBox.Show("مبایل اضافه شده است");
                }
                else
                {
                    MessageBox.Show("اطلاعات تکراری می باشد");
                }
            }
            else if(ToolsBox.Enabled)
            {
                ToolsTB tool = new ToolsTB();
                tool.Barcode = int.Parse(barcode.Text);
                tool.Name = name.Text;
                tool.Price = int.Parse(name.Text);
                tool.Mojodi = int.Parse(mojodi.Value.ToString());
                tool.Type = Type.Text;
                if (crud.CreatTools(tool))
                {
                    MessageBox.Show("کالا اضافه شده است");
                }
                else
                {
                    MessageBox.Show("کالا تکراری می باشد");
                }
            }
            else
            {
                MessageBox.Show("یک نوع کالا را انتخاب کنید");
            }
        }
    }
}
