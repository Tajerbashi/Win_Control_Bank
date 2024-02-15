namespace Presentation.Extentions
{
    public static class FileHandler
    {
        public static string SavePic(this String Name,OpenFileDialog ofd)
        {
            string address = "";
            // محل که نرم افزار از آنجا اجرا میشود در متغییر ذخیره میکند
            var pp = Path.GetDirectoryName(Application.ExecutablePath).Split("\\");
            for (int i = 0; i < pp.Length - 3; i++)
            {
                address += ($"{pp[i]}\\");
            }
            String path = address + @"Pictures\";
            // این شرط چک میکند اگر موجود نبود بساز
            if (!Directory.Exists(path))
            {
                // این دستور دایرکتوری فولدر عکس هارا در فولدر برنامه میسازد
                Directory.CreateDirectory(path);
            }
            // نام که تابع ورودی میگیرد را با وازه کاربر و پسوند عکس در متغییر رشته ذخیره میکند
            string PicName = Name + ".JPG";

            try
            {
                //  در داخل ترای کش ما عکس که فایل دیالوگ برمیگرداند نامش را ذخیره میکند
                String PicPath = ofd.FileName;
                //  توسط تابع کپی ما عکس که از فایل دیالوگ گرفتیم را در آدرس پث که اول گرفتیم به اضافه نامی که در نظر گرفتیم ذخیره میکنیم
                if (!Directory.Exists(path + PicName))
                {
                    File.Copy(PicPath, path + PicName, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطای ثبت تصویر\n" + ex.Message);
            }
            //  این قسمت ما آدرس و نام تصویر که داریم را برمیگردانیم
            return (path + PicName);
        }
    }
}
