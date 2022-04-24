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
        Function Fun = new Function();
        NiceStoreDBEntities DB = new NiceStoreDBEntities();
        bool SW = true;
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
            int total = 0, tedad = 0, index=0;
            bool SWAdd = true;

            #region code
            if (CustomerName.Text.Trim().Length==0)
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
                        if (cell.ColumnIndex == 1 && Phone.Barcode.ToString() == cell.Value.ToString()) //Set your Column Index
                        {
                            //MessageBox.Show(cell.Value.ToString() + " "+ cell.RowIndex.ToString());
                            index = cell.RowIndex;
                            tedad = int.Parse(DGV1.Rows[index].Cells[6].Value.ToString())+int.Parse(TDD.Text);
                            SWAdd=false;
                            //MessageBox.Show(index.ToString() +" "+ tedad.ToString());
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
                                total = int.Parse(TDD.Text) * item.Price;
                                DGV1.Rows.Add(item.ID, item.Barcode, item.Brand, item.Name, item.Mojod, item.Price, TDD.Text, total);
                            }
                        }
                    }
                    else if (tool != null)
                    {
                        foreach (var item in DB.ToolsTBs)
                        {
                            if (item.ID == tool.ID)
                            {
                                total = int.Parse(TDD.Text) * item.Price;
                                DGV1.Rows.Add(item.ID, item.Barcode, item.Type, item.Name, item.Mojodi, item.Price, TDD.Text, total);
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
                            if (item.ID == Phone.ID )
                            {
                                if (item.Mojod < tedad)
                                {
                                    String Note1 = "تعداد موجود در انبار کافی نیست";
                                    String Note2 = "تعداد موجود : ";
                                    MessageBox.Show(Note1 + "\n" + Note2 + item.Mojod);
                                    break;
                                }
                                else
                                {
                                    DGV1.Rows.RemoveAt(index);
                                    total = (int.Parse(TDD.Text) + tedad) * item.Price;
                                    DGV1.Rows.Add(item.ID, item.Barcode, item.Brand, item.Name, item.Mojod, item.Price, tedad, total);

                                }
                            }
                        }
                    }
                    else if (tool != null)
                    {
                        foreach (var item in DB.ToolsTBs)
                        {
                            if ( item.ID == tool.ID )
                            {
                                if (item.Mojodi < tedad)
                                {
                                    String Note1 = "تعداد موجود در انبار کافی نیست";
                                    String Note2 = "تعداد موجود : ";
                                    MessageBox.Show(Note1 + "\n" + Note2 + item.Mojodi);
                                    break;
                                }
                                else
                                {
                                    DGV1.Rows.RemoveAt(index);
                                    total = (int.Parse(TDD.Text) + tedad ) * item.Price;
                                    DGV1.Rows.Add(item.ID, item.Barcode, item.Type, item.Name, item.Mojodi, item.Price, tedad, total);
                                }
                            }
                        }
                    }
                }

                #endregion
                #endregion

            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            DGV1.Rows.Clear();
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            DGV1.Rows.RemoveAt(DGV1.Rows.Count - 1);
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            DGV2.Rows.RemoveAt(DGV2.Rows.Count - 1);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes==MessageBox.Show("آیا تمام کالا های موجود را میخرید؟","تایید درخواست", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                foreach (DataGridViewRow selRow in DGV1.Rows.OfType<DataGridViewRow>().ToArray())
                {
                    DGV1.Rows.Remove(selRow);
                    DGV2.Rows.Add(selRow);
                }
                
                
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
    }
}
