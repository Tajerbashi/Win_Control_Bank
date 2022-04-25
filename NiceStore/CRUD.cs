using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceStore
{
    public class CRUD
    {
        NiceStoreDBEntities DB = new NiceStoreDBEntities();

        public bool CreatCustomer(CustomerTB customer)
        {
            foreach (var item in DB.CustomerTBs)
            {
                if(item.Name==customer.Name && item.Phone == customer.Phone)
                {
                    return false;
                }
            }
            DB.CustomerTBs.Add(customer);
            DB.SaveChanges();
            return true;
        }
        public bool EditCustomer(CustomerTB customer)
        {
            foreach (var item in DB.CustomerTBs)
            {
                if(item.ID != customer.ID && item.Name==customer.Name && item.Phone == customer.Phone)
                {
                    return false;
                }
            }
            CustomerTB Customer = DB.CustomerTBs.Where(c => c.ID == customer.ID).FirstOrDefault();
            Customer.Name = customer.Name;
            Customer.Phone = customer.Phone;
            DB.SaveChanges();
            return true;
        }
        public void DeleteCustomer(int id)
        {
            CustomerTB customer = (DB.CustomerTBs.Where(c => c.ID == id).FirstOrDefault());
            DB.CustomerTBs.Remove(customer);
            DB.SaveChanges();
        }
        public int GetCustomerID(String Name)
        {
            foreach (var item in DB.CustomerTBs)
            {
                if (item.Name==Name)
                {
                    return item.ID;
                }
            }
            return 0;
        }

        public CustomerTB GetCustomer(String Name)
        {
            return (DB.CustomerTBs.Where(c => c.Name==Name).FirstOrDefault());
        }
        public bool CreateProduct(ProductTB product)
        {
            foreach (var item in DB.ProductTBs)
            {
                if ( item.Name == product.Name && item.Barcode == product.Barcode )
                {
                    return false;
                }
            }
            DB.ProductTBs.Add(product);
            DB.SaveChanges();
            return true;
        }
        public bool EditProducr(ProductTB product)
        {
            foreach (var item in DB.ProductTBs)
            {
                if (item.ID != product.ID && item.Name == product.Name && item.Barcode == product.Barcode)
                {
                    return false;
                }
            }
            ProductTB products = DB.ProductTBs.Where(c => c.ID == product.ID).FirstOrDefault();
            products.Name = product.Name;
            products.Price = product.Price;
            products.Mojod = product.Mojod;
            products.Brand = product.Brand;
            products.CPU = product.CPU;
            products.ScreenSize = product.ScreenSize;
            products.Ram = product.Ram;
            DB.SaveChanges();
            return true;
        }
        public void DeleteProduct(int id)
        {
            ProductTB product = (DB.ProductTBs.Where(c => c.ID == id).FirstOrDefault());
            DB.ProductTBs.Remove(product);
            DB.SaveChanges();
        }
        public ProductTB GetProduct(int ID)
        {
            return (DB.ProductTBs.Where(c => c.ID == ID).FirstOrDefault());
        }
        public String GetPhoneNumber(String Name)
        {
            var db = from i in DB.CustomerTBs where i.Name == Name select i;
            foreach (var item in db)
            {
                return item.Phone;
            }
            return null;
        }
        public ProductTB GetPhoneProduct(String Name)
        {
            return (DB.ProductTBs.Where(c => c.Name == Name).FirstOrDefault());
        }


        public void CreatOrderList(OrderListTB orderList)
        {
            DB.OrderListTBs.Add(orderList);
            DB.SaveChanges();
        }
        public void CreatOdertItem(OrderItemTB items)
        {
            DB.OrderItemTBs.Add(items);
            DB.SaveChanges();
        }
        
        public OrderItemTB GetOrderItem(int Code)
        {
            int ID = ((from i in DB.OrderItemTBs select i.ID).Max());
            return (DB.OrderItemTBs.Where(c => c.ID==ID).FirstOrDefault());
        }

        public List<OrderListTB> GetListOrder(int ID)
        {
            return (from i in DB.OrderListTBs where i.CustomerID==ID select i).ToList();
        }
    }
}
