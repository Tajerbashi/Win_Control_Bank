using Account.Application.Library.Models.Controls;

namespace Account.Application.Library.BaseService
{
    public interface IBaseQueries
    {
        /// <summary>
        /// دریافت تعداد رکورد ها
        /// </summary>
        /// <returns></returns>
        string GetCount();
        /// <summary>
        /// نمایش همه رکورد ها
        /// </summary>
        /// <param name="paging"></param>
        /// <returns></returns>
        string ShowAll(string paging);
        /// <summary>
        /// جستجو در میان رکورد ها
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        string Search(string value);
        /// <summary>
        /// جستجو در بازه از تاریخ تا تاریخ
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        string ShowFromTo(string from, string to);
        /// <summary>
        /// دریافت عنوان و مقدار
        /// </summary>
        /// <returns></returns>
        IEnumerable<KeyValue<byte>> TitleValue();
    }
}
