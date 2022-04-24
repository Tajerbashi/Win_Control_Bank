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
        Function Fun = new Function();
        CRUD crud = new CRUD();
        NiceStoreDBEntities DBC = new NiceStoreDBEntities();
        int Barcode = 0;
        int ID = -1;
        bool SW = true;
        //  Show DGV2
        public void ShowPhone()
        {
            DGV2.Rows.Clear();
            var DB = from i in DBC.PhoneTBs select i;
            foreach (var item in DB)
            {
                DGV2.Rows.Add(item.ID, item.Barcode, item.Name, item.Price, item.Mojod, item.Brand);
            }
        }
        public void ShowTools()
        {
            DGV2.Rows.Clear();
            var DB = from i in DBC.ToolsTBs select i;
            foreach (var item in DB)
            {
                DGV2.Rows.Add(item.ID, item.Barcode, item.Name, item.Price, item.Mojodi, item.Type);
            }
        }
        public void ShowResultSearchPhone(String Word)
        {
            DGV2.Rows.Clear();
            var Result = from i in DBC.PhoneTBs where (i.Name).Contains(Word) || (i.Brand).Contains(Word) || ((i.CPU).ToString()).Contains(Word) || ((i.Barcode).ToString()).Contains(Word) select i;
            foreach (var item in Result)
            {
                DGV2.Rows.Add(item.ID, item.Barcode, item.Name, item.Price, item.Mojod, item.Brand);
            }
        }
        public void ShowResultSearchTools(String Word)
        {
            DGV2.Rows.Clear();
            var Result = from i in DBC.ToolsTBs where (i.Name).Contains(Word) || (i.Type).Contains(Word) || ((i.Barcode).ToString()).Contains(Word) select i;
            foreach (var item in Result)
            {
                DGV2.Rows.Add(item.ID, item.Barcode, item.Name, item.Price, item.Mojodi, item.Type);
            }
        }

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Status.Text = "یک گزینه را انتخاب کنید برای نمایش اطلاعات کالا";
            if (comboBoxEx1.SelectedIndex == 0)
            {
                R2.Checked = true;
                ToolsBox.Enabled = false;
                PhoneBox.Enabled = true;
                ShowPhone();
                barcode.Text = Fun.getPhoneBarcode().ToString();
            }
            else
            {
                R1.Checked = true;
                ToolsBox.Enabled = true;
                PhoneBox.Enabled = false;
                ShowTools();
                barcode.Text = Fun.getToolsBarcode().ToString();
            }
        }

        private void AddProductbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SW)
                {
                    if (PhoneBox.Enabled)
                    {
                        PhoneTB phone = new PhoneTB();
                        phone.Barcode = int.Parse(Fun.ChangeToEnglishNumber(barcode.Text));
                        phone.Name = name.Text;
                        phone.Price = int.Parse(Fun.ChangeToEnglishNumber(price.Text));
                        phone.Mojod = int.Parse(Fun.ChangeToEnglishNumber(mojodi.Value.ToString()));
                        phone.Brand = brand.Text;
                        phone.CPU = Int16.Parse(Fun.ChangeToEnglishNumber(cpu.Text));
                        phone.ScreenSize = screensize.Text;
                        phone.RAM = Int16.Parse(Fun.ChangeToEnglishNumber(RAM.Value.ToString()));
                        if (crud.CreatPhone(phone))
                        {
                            Status.Text = "مبایل اضافه شده است";
                            Barcode = (int.Parse(barcode.Text) + 1);
                            ShowPhone();
                            Fun.ClearTextBoxes(this.Controls);
                            barcode.Text = Barcode.ToString();
                        }
                        else
                        {
                            Status.Text = "اطلاعات تکراری می باشد";
                        }
                    }
                    else if (ToolsBox.Enabled)
                    {
                        ToolsTB tool = new ToolsTB();
                        tool.Barcode = int.Parse(Fun.ChangeToEnglishNumber(barcode.Text));
                        tool.Name = name.Text;
                        tool.Price = int.Parse(Fun.ChangeToEnglishNumber(price.Text));
                        tool.Mojodi = int.Parse(Fun.ChangeToEnglishNumber(mojodi.Value.ToString()));
                        tool.Type = Type.Text;
                        if (crud.CreatTools(tool))
                        {
                            Status.Text = "کالا اضافه شده است";
                            Barcode = (int.Parse(barcode.Text) + 1);
                            Fun.ClearTextBoxes(this.Controls);
                            barcode.Text = Barcode.ToString();
                            ShowTools();
                        }
                        else
                        {
                            Status.Text = "کالا تکراری می باشد";
                        }
                    }
                    else
                    {
                        Status.Text = "یک نوع کالا را انتخاب کنید";
                    }
                }
                else if (!SW)
                {
                    if (R2.Checked || comboBoxEx1.SelectedIndex == 0)
                    {
                        PhoneTB phone = new PhoneTB();
                        phone.ID = ID;
                        phone.Barcode = int.Parse(Fun.ChangeToEnglishNumber(barcode.Text));
                        phone.Name = name.Text;
                        phone.Price = int.Parse(Fun.ChangeToEnglishNumber(price.Text));
                        phone.Mojod = int.Parse(Fun.ChangeToEnglishNumber(mojodi.Value.ToString()));
                        phone.Brand = brand.Text;
                        phone.CPU = Int16.Parse(Fun.ChangeToEnglishNumber(cpu.Text));
                        phone.ScreenSize = screensize.Text;
                        phone.RAM = Int16.Parse(Fun.ChangeToEnglishNumber(RAM.Value.ToString()));
                        if (crud.EditPhone(phone))
                        {
                            Status.Text = "مبایل ویرایش شده است";
                            Barcode = (int.Parse(barcode.Text) + 1);
                            ShowPhone();
                            Fun.ClearTextBoxes(this.Controls);
                            barcode.Text = Barcode.ToString();
                            AddProductbtn.Text = "افزودن کالا";
                        }
                        else
                        {
                            Status.Text="اطلاعات تکراری می باشد";
                        }

                    }
                    else if (R1.Checked || comboBoxEx1.SelectedIndex == 1)
                    {
                        ToolsTB tool = new ToolsTB();
                        tool.ID = ID;
                        tool.Barcode = int.Parse(Fun.ChangeToEnglishNumber(barcode.Text));
                        tool.Name = name.Text;
                        tool.Price = int.Parse(Fun.ChangeToEnglishNumber(price.Text));
                        tool.Mojodi = int.Parse(Fun.ChangeToEnglishNumber(mojodi.Value.ToString()));
                        tool.Type = Type.Text;
                        if (crud.EditTools(tool))
                        {
                            Status.Text = "کالا ویرایش شده است";
                            Barcode = (int.Parse(barcode.Text) + 1);
                            Fun.ClearTextBoxes(this.Controls);
                            barcode.Text = Barcode.ToString();
                            ShowTools();
                            AddProductbtn.Text = "افزودن کالا";
                        }
                        else
                        {
                            Status.Text = "کالا تکراری می باشد";
                        }
                    }
                }
                else
                {
                    Status.Text = "یک نوع کالا را انتخاب کنید";
                }

            }
            catch
            {

            }


        }
        private void R1_Click(object sender, EventArgs e)
        {
            if (R1.Checked)
            {
                Status.Text = "لیست لوازم جانبی موجود در انبار";
                ShowTools();
            }else if (R2.Checked)
            {
                Status.Text = "لیست تلفن های همراه موجود در انبار";
                ShowPhone();
            }
        }

        private void DGV2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(DGV2.CurrentRow.Cells[0].Value.ToString());
            DGV2.CurrentRow.Selected = DGV2.CurrentRow.Selected ? false : true;
            if (R1.Checked) //Tools
            {
                BrandLable.Text = DGV2.CurrentRow.Cells[2].Value.ToString() + " " + DGV2.CurrentRow.Cells[5].Value.ToString();
                CpuLable.Enabled = false;
                RamLable.Enabled = false;
                ScreenLabel.Enabled = false;
            }
            else if (R2.Checked)    //  Phones
            {
                BrandLable.Text = Fun.GetBrand(ID);
                CpuLable.Text = Fun.GetCPU(ID);
                RamLable.Text = Fun.GetRAM(ID);
                ScreenLabel.Text = Fun.GetScreen(ID);
            }
            else
            {
                Status.Text = "یک گزینه را انتخاب کنید برای نمایش اطلاعات کالا";
            }
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void buttonX1_Click(object sender, EventArgs e)
        {
            Fun.ClearTextBoxes(this.Controls);
        }

        private void DGV2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X,Cursor.Position.Y);
            }
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("اطلاعات مورد نظر را میخواهید ویرایش کنید؟؟؟","تایید درخواست",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                if ((comboBoxEx1.SelectedIndex == 0 || R2.Checked) && (comboBoxEx1.SelectedIndex != 1 || !R1.Checked))
                {
                    PhoneTB phone = crud.GetPhone(ID);
                    barcode.Text = phone.Barcode.ToString();
                    name.Text = phone.Name;
                    price.Text = phone.Price.ToString();
                    mojodi.Value = phone.Mojod;
                    brand.Text = phone.Brand;
                    cpu.Text = phone.CPU.ToString();
                    screensize.Text = phone.ScreenSize;
                    RAM.Value = phone.RAM;
                }
                else if ((comboBoxEx1.SelectedIndex == 1 || R1.Checked)&& (comboBoxEx1.SelectedIndex != 0 || !R2.Checked))
                {
                    ToolsTB tool = crud.GetTools(ID);
                    barcode.Text = tool.Barcode.ToString();
                    name.Text = tool.Name;
                    price.Text = tool.Price.ToString();
                    mojodi.Value = tool.Mojodi;
                    Type.Text = tool.Type;
                }
                SW = false;
                AddProductbtn.Text = "بروزرسانی";
            }
            
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("اطلاعات مورد نظر را میخواهید ویرایش کنید؟؟؟", "تایید درخواست", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (comboBoxEx1.SelectedIndex == 0 || R2.Checked)
                {
                    crud.DeletePhone(ID);
                    Status.Text = "اطلاعات تلفن همراه حذف شده است";
                    ShowPhone();
                }
                else if (comboBoxEx1.SelectedIndex == 1 || R1.Checked)
                {
                    crud.DeleteTools(ID);
                    Status.Text = "اطلاعات کالای مورد نظر حذف شده است";
                    ShowTools();
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if(R1.Checked || comboBoxEx1.SelectedIndex == 1)
            {
                ShowResultSearchTools(searchtxt.Text);
            }
            else if(R2.Checked || comboBoxEx1.SelectedIndex==0)
            {
                ShowResultSearchPhone(searchtxt.Text);
            }
        }

        private void ProductPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
