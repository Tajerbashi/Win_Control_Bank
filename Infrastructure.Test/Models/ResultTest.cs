namespace Infrastructure.Test.Models
{
    public class ResultTest<T>
    {
        public T Result { get; set; }
        public string Message { get; set; }
    }
    public static class MessagesResponse
    {
        /// <summary>
        /// اطلاعات تکراری است
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static string Duplicate(string model = "")
        {
            return ($"اطلاعات تکراری است\n{model}");
        }
        /// <summary>
        /// مدل خالی است
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static string EmptyModel(string model = "")
        {
            return ($"مدل خالی است\n{model}");
        }
        /// <summary>
        /// عملیات انجام نشده است
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static string Faild(string model = "")
        {
            return ($"عملیات انجام نشده است\n{model}");
        }
        /// <summary>
        /// اطلاعات یافت نشده است
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static string NotFound(string model = "")
        {
            return ($"اطلاعات یافت نشده است\n{model}");
        }
        /// <summary>
        /// عملیات با موفقیت انجام شده است
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static string Success(string model = "")
        {
            return ($"عملیات با موفقیت انجام شده است\n{model}");
        }
        /// <summary>
        /// اطلاعات اشتباه است
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static string WrongData(string model = "")
        {
            return ($"اطلاعات اشتباه است\n{model}");
        }
    }
}
