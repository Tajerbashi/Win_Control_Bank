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
            var DB = from i in DBC.ProductTBs select i;
            foreach (var item in DB)
            {
                if (item.Type==1)
                {
                    DGV2.Rows.Add(item.ID, item.Barcode, item.Name, item.Price, item.Mojod, item.Brand);
                }
            }
        }
        public void ShowTools()
        {
            DGV2.Rows.Clear();
            var DB = from i in DBC.ProductTBs select i;
            foreach (var item in DB)
            {
                if (item.Type == 2)
                {
                    DGV2.Rows.Add(item.ID, item.Barcode, item.Name, item.Price, item.Mojod, item.Brand);
                }
            }
        }
        public void ShowResultSearchPhone(String Word,int Type)
        {
            DGV2.Rows.Clear();
            var Result = from i in DBC.ProductTBs where (i.Name).Contains(Word) || (i.Brand).Contains(Word) || ((i.CPU).ToString()).Contains(Word) || ((i.Barcode).ToString()).Contains(Word) select i;
            foreach (var item in Result)
            {
                if (item.Type == Type)
                {
                    DGV2.Rows.Add(item.ID, item.Barcode, item.Name, item.Price, item.Mojod, item.Brand);
                }
            }
        }
        public void ShowResultSearchTools(String Word,int Type)
        {
            DGV2.Rows.Clear();
            var Result = from i in DBC.ProductTBs where (i.Name).Contains(Word) || (i.Brand).Contains(Word) || ((i.Barcode).ToString()).Contains(Word) select i;
            foreach (var item in Result)
            {
                if (item.Type == 1 && Type == 1)
                {
                    DGV2.Rows.Add(item.ID, item.Barcode, item.Name, item.Price, item.Mojod, item.Type);
                }
                else
                {
                    DGV2.Rows.Add(item.ID, item.Barcode, item.Name, item.Price, item.Mojod, item.Type);
                }
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
            }
            else
            {
                R1.Checked = true;
                ToolsBox.Enabled = true;
                PhoneBox.Enabled = false;
                ShowTools();
            }
            barcode.Text = Fun.GetProductBarcode().ToString();

        }
        private void AddProductbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SW)
                {
                    if (PhoneBox.Enabled)
                    {
                        ProductTB product = new ProductTB();
                        product.Barcode = int.Parse(Fun.ChangeToEnglishNumber(barcode.Text));
                        product.Name = name.Text;
                        product.Price = int.Parse(Fun.ChangeToEnglishNumber(price.Text));
                        product.Mojod = int.Parse(Fun.ChangeToEnglishNumber(mojodi.Value.ToString()));
                        product.Brand = brand.Text;
                        product.CPU = Int16.Parse(Fun.ChangeToEnglishNumber(cpu.Text));
                        product.ScreenSize = screensize.Text;
                        product.Ram = Int16.Parse(Fun.ChangeToEnglishNumber(RAM.Value.ToString()));
                        product.Type = 1;
                        if (crud.CreateProduct(product))
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
                        ProductTB product = new ProductTB();
                        product.Barcode = int.Parse(Fun.ChangeToEnglishNumber(barcode.Text));
                        product.Name = name.Text;
                        product.Brand = Type.Text;
                        product.Price = int.Parse(Fun.ChangeToEnglishNumber(price.Text));
                        product.Mojod = int.Parse(Fun.ChangeToEnglishNumber(mojodi.Value.ToString()));
                        product.Type = 2;
                        if (crud.CreateProduct(product))
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
                        ProductTB product = new ProductTB();
                        product.ID = ID;
                        product.Name = name.Text;
                        product.Price = int.Parse(Fun.ChangeToEnglishNumber(price.Text));
                        product.Mojod = int.Parse(Fun.ChangeToEnglishNumber(mojodi.Value.ToString()));
                        product.Brand = brand.Text;
                        product.CPU = Int16.Parse(Fun.ChangeToEnglishNumber(cpu.Text));
                        product.ScreenSize = screensize.Text;
                        product.Ram = Int16.Parse(Fun.ChangeToEnglishNumber(RAM.Value.ToString()));
                        if (crud.EditProducr(product))
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
                        ProductTB product = new ProductTB();
                        product.ID = ID;
                        product.Barcode = int.Parse(Fun.ChangeToEnglishNumber(barcode.Text));
                        product.Name = name.Text;
                        product.Brand = Type.Text;
                        product.Price = int.Parse(Fun.ChangeToEnglishNumber(price.Text));
                        product.Mojod = int.Parse(Fun.ChangeToEnglishNumber(mojodi.Value.ToString()));
                        if (crud.EditProducr(product))
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
                    ProductTB phone = crud.GetProduct(ID);
                    barcode.Text = phone.Barcode.ToString();
                    name.Text = phone.Name;
                    price.Text = phone.Price.ToString();
                    mojodi.Value = phone.Mojod;
                    brand.Text = phone.Brand;
                    cpu.Text = phone.CPU.ToString();
                    screensize.Text = phone.ScreenSize;
                    RAM.Value = Convert.ToDecimal(phone.Ram);
                }
                else if ((comboBoxEx1.SelectedIndex == 1 || R1.Checked)&& (comboBoxEx1.SelectedIndex != 0 || !R2.Checked))
                {
                    ProductTB tool = crud.GetProduct(ID);
                    barcode.Text = tool.Barcode.ToString();
                    name.Text = tool.Name;
                    price.Text = tool.Price.ToString();
                    mojodi.Value = tool.Mojod;
                    Type.Text = tool.Type.ToString();
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
                    crud.DeleteProduct(ID);
                    Status.Text = "اطلاعات تلفن همراه حذف شده است";
                    ShowPhone();
                }
                else if (comboBoxEx1.SelectedIndex == 1 || R1.Checked)
                {
                    crud.DeleteProduct(ID);
                    Status.Text = "اطلاعات کالای مورد نظر حذف شده است";
                    ShowTools();
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if(R1.Checked || comboBoxEx1.SelectedIndex == 1)
            {
                ShowResultSearchTools(searchtxt.Text,2);
            }
            else if(R2.Checked || comboBoxEx1.SelectedIndex==0)
            {
                ShowResultSearchPhone(searchtxt.Text,1);
            }
        }

        private void ProductPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
