using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NiceStore
{
    public class Function
    {
        NiceStoreDBEntities DB = new NiceStoreDBEntities();
        #region Functions

        public int getPhoneBarcode()
        {
            try
            {
                int Barcode = ((from i in DB.PhoneTBs select i.Barcode).Max() + 1);
                return Barcode;
            }
            catch
            {
                return 1001;
            }
            
        }
        public int getToolsBarcode()
        {
            try
            {
                int Barcode = ((from i in DB.ToolsTBs select i.Barcode).Max() + 1);
                return Barcode;
            }
            catch
            {
                return 1001;
            }
        }

        public String GetBrand(int ID)
        {
            var B =(from i in DB.PhoneTBs where i.ID==ID select i);
            foreach (var item in B)
            {
                return item.Brand;
            }
            return "موجود نیست";
        }
        public String GetCPU(int ID)
        {
            var B = (from i in DB.PhoneTBs where i.ID == ID select i);
            foreach (var item in B)
            {
                return ((item.CPU).ToString());
            }
            return "موجود نیست";
        }
        public String GetRAM(int ID)
        {
            var B = (from i in DB.PhoneTBs where i.ID == ID select i);
            foreach (var item in B)
            {
                return ((item.RAM).ToString()); ;
            }
            return "موجود نیست";
        }
        public String GetScreen(int ID)
        {
            var B = (from i in DB.PhoneTBs where i.ID == ID select i);
            foreach (var item in B)
            {
                return item.ScreenSize;
            }
            return "موجود نیست";
        }
        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }
        public String ChangeToEnglishNumber(String text)
        {
            var englishNumbers = String.Empty;
            for (var i = 0; i < text.Length; i++)
            {
                if (char.IsNumber(text[i])) englishNumbers += char.GetNumericValue(text, i);
                else englishNumbers += text[i];
            }

            return englishNumbers;
        }
        #endregion
    }
}
