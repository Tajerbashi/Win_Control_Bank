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
                if(item.id != customer.id && item.Name==customer.Name && item.Phone == customer.Phone)
                {
                    return false;
                }
            }
            CustomerTB Customer = DB.CustomerTBs.Where(c => c.id == customer.id).FirstOrDefault();
            Customer.Name = customer.Name;
            Customer.Phone = customer.Phone;
            DB.SaveChanges();
            return true;
        }
        public void DeleteCustomer(int id)
        {
            CustomerTB customer = (DB.CustomerTBs.Where(c => c.id == id).FirstOrDefault());
            DB.CustomerTBs.Remove(customer);
            DB.SaveChanges();
        }


        public bool CreatPhone(PhoneTB phone)
        {
            foreach (var item in DB.PhoneTBs)
            {
                if ( item.Name == phone.Name && item.Barcode == phone.Barcode )
                {
                    return false;
                }
            }
            DB.PhoneTBs.Add(phone);
            DB.SaveChanges();
            return true;
        }
        public bool EditPhone(PhoneTB phone)
        {
            foreach (var item in DB.PhoneTBs)
            {
                if (item.ID != phone.ID && item.Name == phone.Name && item.Barcode == phone.Barcode)
                {
                    return false;
                }
            }
            PhoneTB phones = DB.PhoneTBs.Where(c => c.ID == phone.ID).FirstOrDefault();
            phones.Name = phone.Name;
            phones.Price = phone.Price;
            phones.Mojod = phone.Mojod;
            phones.Brand = phone.Brand;
            phones.CPU = phone.CPU;
            phones.ScreenSize = phone.ScreenSize;
            phones.RAM = phone.RAM;
            DB.SaveChanges();
            return true;
        }
        public void DeletePhone(int id)
        {
            PhoneTB phone = (DB.PhoneTBs.Where(c => c.ID == id).FirstOrDefault());
            DB.PhoneTBs.Remove(phone);
            DB.SaveChanges();
        }
        public PhoneTB GetPhone(int ID)
        {
            return (DB.PhoneTBs.Where(c => c.ID == ID).FirstOrDefault());
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
        public PhoneTB GetPhoneProduct(String Name)
        {
            return (DB.PhoneTBs.Where(c => c.Name == Name).FirstOrDefault());
        }


        public bool CreatTools(ToolsTB tool)
        {
            foreach (var item in DB.ToolsTBs)
            {
                if (item.Name == tool.Name && item.Barcode == tool.Barcode )
                {
                    return false;
                }
            }
            DB.ToolsTBs.Add(tool);
            DB.SaveChanges();
            return true;
        }
        public bool EditTools(ToolsTB tool)
        {
            foreach (var item in DB.ToolsTBs)
            {
                if ( item.ID  != tool.ID && item.Barcode == tool.Barcode )
                {
                    return false;
                }
            }
            ToolsTB tools = DB.ToolsTBs.Where(c => c.ID == tool.ID).FirstOrDefault();
            tools.Name = tool.Name;
            tools.Price = tool.Price;
            tools.Mojodi = tool.Mojodi;
            tools.Type = tool.Type;
            DB.SaveChanges();
            return true;
        }
        public void DeleteTools(int id)
        {
            ToolsTB tools = (DB.ToolsTBs.Where(c => c.ID == id).FirstOrDefault());
            DB.ToolsTBs.Remove(tools);
            DB.SaveChanges();
        }
        public ToolsTB GetTools(int ID)
        {
            return (DB.ToolsTBs.Where(c => c.ID == ID).FirstOrDefault());
        }
        public ToolsTB GetToolsProduct(String Name)
        {
            return (DB.ToolsTBs.Where(c => c.Name == Name).FirstOrDefault());
        }


    }
}
