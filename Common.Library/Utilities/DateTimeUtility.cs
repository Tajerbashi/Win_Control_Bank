using Common.Library.Models;
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

        public static Result<IEnumerable<KeyValueObject>> GetMonth()
        {
            var result = new List<KeyValueObject>
            {
                new KeyValueObject{ Title ="فروردین" , Value =1},
                new KeyValueObject{ Title ="اردیبهشت" , Value =2},
                new KeyValueObject{ Title ="خرداد" , Value =3},
                new KeyValueObject{ Title ="تیر" , Value =4},
                new KeyValueObject{ Title ="مرداد" , Value =5},
                new KeyValueObject{ Title ="شهریور" , Value =6},
                new KeyValueObject{ Title ="مهر" , Value =7},
                new KeyValueObject{ Title ="آبان" , Value =8},
                new KeyValueObject{ Title ="آذر" , Value =9},
                new KeyValueObject{ Title ="دی" , Value =10},
                new KeyValueObject{ Title ="بهمن" , Value =11},
                new KeyValueObject{ Title ="اسفند" , Value =12},
            };
            return new Result<IEnumerable<KeyValueObject>> { Data = result };
        }
        public static Result<IEnumerable<KeyValueObject>> GetDaysOfWeek()
        {
            var result = new List<KeyValueObject>
            {
                new KeyValueObject{ Title ="شنبه" , Value =0},
                new KeyValueObject{ Title ="یکشنبه" , Value =1},
                new KeyValueObject{ Title ="دوشنبه" , Value =2},
                new KeyValueObject{ Title ="سه شنبه" , Value =3},
                new KeyValueObject{ Title ="چهارشنبه" , Value =4},
                new KeyValueObject{ Title ="پنچشنبه" , Value =5},
                new KeyValueObject{ Title ="جمعه" , Value =6},
            };
            return new Result<IEnumerable<KeyValueObject>> { Data = result };
        }
    }

}
