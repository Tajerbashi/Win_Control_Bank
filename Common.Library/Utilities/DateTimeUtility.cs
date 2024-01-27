using System.Globalization;

namespace Common.Library.Utilities
{
    public static class DateTimeUtility
    {
        public static DateTime ToDateTime(this DateTime dateTime) { return dateTime.ToUniversalTime(); }
        public static string ToPersion(this DateTime dateTime)
        {
            PersianCalendar pc = new PersianCalendar();
            return (string.Format("{0}/{1}/{2}", pc.GetYear(dateTime), pc.GetMonth(dateTime), pc.GetDayOfMonth(dateTime)));
        }
        public static string ToPersionFormat(this DateTime dateTime, string format = "yyyy/MM/dd HH:mm:ss")
        {
            var calendar = new PersianCalendar();
            //var persianDate = new DateTime(
            //    calendar.GetYear(dateTime),
            //    calendar.GetMonth(dateTime),
            //    calendar.GetDayOfMonth(dateTime),
            //    calendar.GetHour(dateTime),
            //    calendar.GetMinute(dateTime),
            //    calendar.GetSecond(dateTime));
            //var result = persianDate.ToString(format, CultureInfo.GetCultureInfo("fa-Ir"));
            var result = (string.Format("{0}/{1}/{2} {3}:{4}:{5}",
                calendar.GetYear(dateTime),
                calendar.GetMonth(dateTime),
                calendar.GetDayOfMonth(dateTime),
                calendar.GetHour(dateTime),
                calendar.GetMinute(dateTime),
                calendar.GetSecond(dateTime)));

            return result;
        }

    }

}
