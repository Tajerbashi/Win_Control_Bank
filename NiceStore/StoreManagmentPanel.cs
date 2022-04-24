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
    public partial class StoreManagmentPanel : UserControl
    {
        public StoreManagmentPanel()
        {
            InitializeComponent();
        }
        CRUD crud = new CRUD();
        NiceStoreDBEntities DB = new NiceStoreDBEntities();
        Function Fun = new Function();
        int ID = -1;

        public void CustomerNameF()
        {
            CustomerName.Items.Clear();
            foreach (var item in DB.CustomerTBs)
            {
                CustomerName.Items.Add(item.Name);
            }
        }
        public void ProductNameF()
        {
            ProductName.Items.Clear();
            foreach (var item in DB.PhoneTBs)
            {
                ProductName.Items.Add(item.Name);
            }
            foreach (var item in DB.ToolsTBs)
            {
                ProductName.Items.Add(item.Name);
            }
        }
        private void StoreManagmentPanel_Load(object sender, EventArgs e)
        {
            CustomerNameF();
            ProductNameF();
        }
        private void CustomerName_SelectedValueChanged(object sender, EventArgs e)
        {
            PhoneNumber.Text = crud.GetPhoneNumber(CustomerName.Text);
        }
        private void ProductName_SelectedValueChanged(object sender, EventArgs e)
        {
            var Phone= crud.GetPhoneProduct(ProductName.Text);
            var tool= crud.GetToolsProduct(ProductName.Text);
            if (Phone != null)
            {
                StatusProduct.Text = "تلفن همراه موجود است";

            }
            else if (tool != null)
            {
                StatusProduct.Text = "کالا موجود است";

            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            int inputNumber = int.Parse( Fun.ChangeToEnglishNumber(TDD.Text));
            int index = 0, dtNumber = 0, dbNumber = 0 ;
            int totalPrice = 0;
            bool SWAdd = true;
            try
            {
                #region code
                if (CustomerName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("نام مشتری را انتخاب کنید");
                    CustomerName.Select();
                }
                else if (ProductName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("محصولی بری اضافه کردن انتخاب کنید");
                    ProductName.Select();
                }
                else if (TDD.Text.Trim().Length == 0)
                {
                    MessageBox.Show("محصولی بری اضافه کردن انتخاب کنید");
                    TDD.Focus();
                }
                else
                {
                    #region Code

                    var Phone = crud.GetPhoneProduct(ProductName.Text);
                    var tool = crud.GetToolsProduct(ProductName.Text);

                    foreach (DataGridViewRow row in DGV1.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (Phone != null)
                            {
                                if ( cell.ColumnIndex == 1 && Phone.Barcode.ToString() == cell.Value.ToString() )
                                {
                                    index = cell.RowIndex;
                                    dtNumber = int.Parse(DGV1.Rows[index].Cells[6].Value.ToString()) + inputNumber;
                                    SWAdd = false;
                                }
                            }
                            else 
                            if(tool != null)
                            {
                                if (cell.ColumnIndex == 1 && tool.Barcode.ToString() == cell.Value.ToString())
                                {
                                    index = cell.RowIndex;
                                    dtNumber = int.Parse(DGV1.Rows[index].Cells[6].Value.ToString()) + inputNumber;
                                    SWAdd = false;
                                }
                            }
                        }
                    }

                    if (SWAdd)
                    {
                        if (Phone != null)
                        {
                            foreach (var item in DB.PhoneTBs)
                            {
                                if (item.ID == Phone.ID)
                                {
                                    if (item.Mojod < dtNumber)
                                    {
                                        String Note1 = "تعداد موجود در انبار کافی نیست";
                                        String Note2 = "تعداد موجود : ";
                                        MessageBox.Show(Note1 + "\n" + Note2 + item.Mojod);
                                        break;
                                    }
                                    else
                                    {
                                        totalPrice = inputNumber * item.Price;
                                        DGV1.Rows.Add(item.ID, item.Barcode, item.Brand, item.Name, item.Mojod, item.Price, inputNumber, totalPrice);
                                    }
                                }
                            }
                        }
                        else if (tool != null)
                        {
                            foreach (var item in DB.ToolsTBs)
                            {
                                if (item.ID == tool.ID)
                                {
                                    if (item.Mojodi < dtNumber)
                                    {
                                        String Note1 = "تعداد موجود در انبار کافی نیست";
                                        String Note2 = "تعداد موجود : ";
                                        MessageBox.Show(Note1 + "\n" + Note2 + item.Mojodi);
                                        break;
                                    }
                                    else
                                    {
                                        totalPrice = inputNumber * item.Price;
                                        DGV1.Rows.Add(item.ID, item.Barcode, item.Type, item.Name, item.Mojodi, item.Price, inputNumber, totalPrice);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (Phone != null)
                        {
                            foreach (var item in DB.PhoneTBs)
                            {
                                if (item.ID == Phone.ID)
                                {
                                    if (item.Mojod < dtNumber)
                                    {
                                        String Note1 = "تعداد موجود در انبار کافی نیست";
                                        String Note2 = "تعداد موجود : ";
                                        MessageBox.Show(Note1 + "\n" + Note2 + item.Mojod);
                                        break;
                                    }
                                    else
                                    {
                                        DGV1.Rows.RemoveAt(index);
                                        totalPrice = (inputNumber + dtNumber) * item.Price;
                                        DGV1.Rows.Add(item.ID, item.Barcode, item.Brand, item.Name, item.Mojod, item.Price, dtNumber, totalPrice);
                                    }
                                }
                            }
                        }
                        else if (tool != null)
                        {
                            foreach (var item in DB.ToolsTBs)
                            {
                                if (item.ID == tool.ID)
                                {
                                    if (item.Mojodi < dtNumber)
                                    {
                                        String Note1 = "تعداد موجود در انبار کافی نیست";
                                        String Note2 = "تعداد موجود : ";
                                        MessageBox.Show(Note1 + "\n" + Note2 + item.Mojodi);
                                        break;
                                    }
                                    else
                                    {
                                        DGV1.Rows.RemoveAt(index);
                                        totalPrice = (inputNumber + dtNumber) * item.Price;
                                        DGV1.Rows.Add(item.ID, item.Barcode, item.Type, item.Name, item.Mojodi, item.Price, dtNumber, totalPrice);
                                    }
                                }
                            }
                        }
                    }
                    #endregion
                }
                #endregion

            }
            catch
            {

            }

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            DGV1.Rows.Clear();
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            try
            {
                DGV1.Rows.RemoveAt(DGV1.Rows.Count - 1);
            }
            catch
            {

            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            try
            {
                DGV2.Rows.RemoveAt(DGV2.Rows.Count - 1);
            }
            catch
            {

            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("آیا تمام کالا های موجود را میخرید؟", "تایید درخواست", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    foreach (DataGridViewRow selRow in DGV1.Rows.OfType<DataGridViewRow>().ToArray())
                    {
                        DGV1.Rows.Remove(selRow);
                        DGV2.Rows.Add(selRow);
                    }
                }
            }
            catch
            {
                MessageBox.Show("از اطلاعات وارد شده مطمیین شوید");
            }
            
            
        }

        private void DGV1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                ID = int.Parse(DGV1.CurrentRow.Cells[0].Value.ToString());
                DGV1.CurrentRow.Selected = (DGV1.CurrentRow.Selected) ? false : true;
            }
        }

        private void DGV2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                ID = int.Parse(DGV1.CurrentRow.Cells[0].Value.ToString());
                DGV2.CurrentRow.Selected = (DGV2.CurrentRow.Selected) ? false : true;
            }
        }

        private void TDD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
