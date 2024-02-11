using System.Globalization;

namespace Account.Presentation.Extentions
{
    public static class DateUtilities
    {
        public static string PersianDate()
        {
            DateTime d = DateTime.Now;
            PersianCalendar pc = new PersianCalendar();
            var hover = pc.GetHour(d) > 12 ? pc.GetHour(d) - 12 : pc.GetHour(d);
            var mode = pc.GetHour(d) > 12 ? "بعد از ظهر" : "قبل از ظهر";

            return $"{pc.GetYear(d)}/{pc.GetMonth(d)}/{pc.GetDayOfMonth(d)} {hover}:{pc.GetMinute(d)}:{pc.GetSecond(d)} {mode}";
        }
        public static string ConvertToPersianDate(DateTime date,string format = "")
        {
            PersianCalendar pc = new PersianCalendar();
            var hover = pc.GetHour(date) > 12 ? pc.GetHour(date) - 12 : pc.GetHour(date);
            var mode = pc.GetHour(date) > 12 ? "بعد از ظهر" : "قبل از ظهر";

            return $"{pc.GetYear(date)}/{pc.GetMonth(date)}/{pc.GetDayOfMonth(date)} {hover}:{pc.GetMinute(date)}:{pc.GetSecond(date)} {mode}";
        }
    }
}
