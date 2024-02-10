
namespace Common.Library.Extentions
{
    public static class MessageProject
    {
        /// <summary>
        /// عملیات با موفقیت انجام شده است
        /// </summary>
        /// <returns></returns>
        public static string Success()
        {
            return ($"عملیات با موفقیت انجام شده است");
        }

        /// <summary>
        /// هشدار! برای این عملیات بازنگری داده لازم است
        /// </summary>
        /// <returns></returns>
        public static string Warning()
        {
            return ($"هشدار! برای این عملیات بازنگری داده لازم است");
        }

        /// <summary>
        /// عملیات ناموق بود
        /// </summary>
        /// <returns></returns>
        public static string Faild()
        {
            return ($"عملیات ناموق بود");
        }

        /// <summary>
        /// اطلاعات یافت نشده است
        /// </summary>
        /// <returns></returns>
        public static string NotFound(string word="اطلاعات")
        {
            return ($"{word} یافت نشده است");
        }

        /// <summary>
        /// اطلاعات درست نیست بازنگری کنید لطفا
        /// </summary>
        /// <returns></returns>
        public static string InvalidModel(string word = "اطلاعات")
        {
            return ($"{word} درست نیست بازنگری کنید لطفا");
        }

        /// <summary>
        /// موجودی کافی نیست
        /// </summary>
        /// <returns></returns>
        public static string NotEnughBlance()
        {
            return ($"موجودی کافی نیست و این تراکنش انجام نمیشود");
        }

        /// <summary>
        /// هنوز هیچ نوع تراکنشی تایید نشده است
        /// </summary>
        /// <returns></returns>
        public static string NotSelectTransaction()
        {
            return ($"هنوز هیچ نوع تراکنشی تایید نشده است");
        }
    }
}
