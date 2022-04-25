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
        bool sw = true;

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
            foreach (var item in DB.ProductTBs)
            {
                ProductName.Items.Add(item.Name);
            }
        }
        private void StoreManagmentPanel_Load(object sender, EventArgs e)
        {
            CustomerNameF();
            ProductNameF();
            cartcode.Text = Fun.GetLastOrderListCode().ToString();
        }
        private void CustomerName_SelectedValueChanged(object sender, EventArgs e)
        {
            PhoneNumber.Text = crud.GetPhoneNumber(CustomerName.Text);
        }
        private void ProductName_SelectedValueChanged(object sender, EventArgs e)
        {
            var Phone= crud.GetPhoneProduct(ProductName.Text);
            if (Phone != null)
            {
                StatusProduct.Text = "کالا موجود است";
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
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
                    int inputNumber = int.Parse(Fun.ChangeToEnglishNumber(TDD.Text));
                    int index = 0, dtNumber = 0;
                    int totalPrice = 0;
                    bool SWAdd = true;
                    var product = crud.GetPhoneProduct(ProductName.Text);

                    foreach (DataGridViewRow row in DGV1.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (product != null)
                            {
                                if ( cell.ColumnIndex == 1 && product.Barcode.ToString() == cell.Value.ToString() )
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
                        if (product != null)
                        {
                            foreach (var item in DB.ProductTBs)
                            {
                                if (item.ID == product.ID)
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
                    }
                    else
                    {
                        if (product != null)
                        {
                            foreach (var item in DB.ProductTBs)
                            {
                                if (item.ID == product.ID)
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
                                        totalPrice = (dtNumber) * item.Price;
                                        DGV1.Rows.Add(item.ID, item.Barcode, item.Brand, item.Name, item.Mojod, item.Price, dtNumber, totalPrice);
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
            int total = 0;
            try
            {
                if (DialogResult.Yes == MessageBox.Show("آیا تمام کالا های موجود را میخرید؟", "تایید درخواست", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (sw)
                    {
                        foreach (DataGridViewRow selRow in DGV1.Rows.OfType<DataGridViewRow>().ToArray())
                        {
                            DGV1.Rows.Remove(selRow);
                            DGV2.Rows.Add(selRow);
                        }
                        for (int i=0;i<DGV2.Rows.Count;i++)
                        {
                            total += int.Parse(DGV2.Rows[i].Cells[7].Value.ToString());
                        }
                        TotalFactor.Text = total.ToString();
                    }
                    else
                    {
                        MessageBox.Show("سبد خرید قفل شده است برای اضافه کردن پاک کنید دوباره سبد خرید را پرکنید","خطا",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                    sw = false;
                }
            }
            catch
            {
                MessageBox.Show("از اطلاعات وارد شده مطمیین شوید");
            }
        }

        private void DGV1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
                {
                    DGV1.CurrentRow.Selected = (DGV1.CurrentRow.Selected) ? false : true;
                }

            }
            catch
            {

            }
        }

        private void DGV2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
                {
                    DGV2.CurrentRow.Selected = (DGV2.CurrentRow.Selected) ? false : true;
                }
            }catch
            {

            }
            
        }

        private void TDD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            DGV2.Rows.Clear();
            sw = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DGV1.Rows.Clear();
            DGV2.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerTB customer = crud.GetCustomer(CustomerName.Text);
            for (int i=0;i<DGV2.RowCount;i++)
            {
                OrderItemTB item = new OrderItemTB();
                int IDD = int.Parse(DGV2.Rows[i].Cells[0].Value.ToString());
                ProductTB Product= crud.GetProduct(IDD);
                item.ProductID = Product.ID;
                item.BuyCount= int.Parse(DGV2.Rows[i].Cells[6].Value.ToString());
                item.SellPrice= int.Parse(DGV2.Rows[i].Cells[5].Value.ToString());
                item.TotalPrice= int.Parse(DGV2.Rows[i].Cells[7].Value.ToString());
                item.Code = int.Parse(cartcode.Text);
                crud.CreatOdertItem(item);

                OrderItemTB order = crud.GetOrderItem(item.Code);

                OrderListTB list = new OrderListTB();
                list.OrderItemID = order.ID;
                list.CustomerID = customer.ID;
                list.Date = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
                list.Code= int.Parse(cartcode.Text);
                crud.CreatOrderList(list);
            }
            DGV2.Rows.Clear();
            cartcode.Text = (int.Parse(cartcode.Text) + 1).ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
