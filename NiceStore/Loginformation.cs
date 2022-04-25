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
    public partial class Loginformation : UserControl
    {
        public Loginformation()
        {
            InitializeComponent();
        }
        CRUD crud = new CRUD();
        NiceStoreDBEntities DB = new NiceStoreDBEntities();
        private void CustomerName_SelectedValueChanged(object sender, EventArgs e)
        {
            DGV1.Rows.Clear();
            int IDCustomer = crud.GetCustomerID(CustomerName.Text);
            PhoneNumber.Text = crud.GetPhoneNumber(CustomerName.Text);
            // MessageBox.Show(IDCustomer.ToString());
            List<OrderListTB> List = crud.GetListOrder(IDCustomer);
            foreach (var item in List)
            {
                foreach (var order in DB.OrderItemTBs)
                {
                    if (item.OrderItemID==order.ID)
                    {
                        int BuyCount = order.BuyCount;
                        int Total = order.TotalPrice;
                        foreach (var product in DB.ProductTBs)
                        {
                            if (order.ProductID==product.ID)
                            {
                                DGV1.Rows.Add(product.ID,product.Barcode,product.Brand,product.Name,product.Price,BuyCount,Total);
                            }
                        }
                    }

                }
            }

        }
        public void CustomerNameF()
        {
            CustomerName.Items.Clear();
            foreach (var item in DB.CustomerTBs)
            {
                CustomerName.Items.Add(item.Name);
            }
        }
        private void Loginformation_Load(object sender, EventArgs e)
        {
            CustomerNameF();
        }
    }
}
