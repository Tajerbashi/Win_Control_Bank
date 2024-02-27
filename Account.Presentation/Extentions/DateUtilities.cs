using Account.Application.Library.Models.Controls;
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string ConvertToPersianDate(this DateTime date, string format = "")
        {
            PersianCalendar pc = new PersianCalendar();
            var hover = pc.GetHour(date) > 12 ? pc.GetHour(date) - 12 : pc.GetHour(date);
            var mode = pc.GetHour(date) > 12 ? "بعد از ظهر" : "قبل از ظهر";

            return $"{pc.GetYear(date)}/{pc.GetMonth(date)}/{pc.GetDayOfMonth(date)} {hover}:{pc.GetMinute(date)}:{pc.GetSecond(date)} {mode}";
        }
        /// <summary>
        /// سال
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<KeyValue<int>> TitleValueYear()
        {
            var result = new List<KeyValue<int>>();
            for (var i = 1; i < 10; i++)
            {
                result.Add(new KeyValue<int>
                {
                    Key = ($"سال {1400 + i}"),
                    Value = (1400 + i)
                });
            }
            return result.ToList();
        }
        /// <summary>
        /// ماه فارسی
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<KeyValue<int>> TitleValueMonthPersian()
        {
            var result = new List<KeyValue<int>>{
                new KeyValue<int>{ Key="فروردین", Value=1},
                new KeyValue<int>{ Key="اردیبهشت", Value=2},
                new KeyValue<int>{ Key="خرداد", Value=3},
                new KeyValue<int>{ Key="تیر", Value=4},
                new KeyValue<int>{ Key="مرداد", Value=5},
                new KeyValue<int>{ Key="شهریور", Value=6},
                new KeyValue<int>{ Key="مهر", Value=7},
                new KeyValue<int>{ Key="آبان", Value=8},
                new KeyValue<int>{ Key="آذر", Value=9},
                new KeyValue<int>{ Key="دی", Value=10},
                new KeyValue<int>{ Key="بهمن", Value=11},
                new KeyValue<int>{ Key="اسفند", Value=12},
            };

            return result.ToList();
        }
        /// <summary>
        /// ماه دری
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<KeyValue<int>> TitleValueMonthDari()
        {
            var result = new List<KeyValue<int>>{
                new KeyValue<int>{ Key="حمل", Value=1},
                new KeyValue<int>{ Key="ثور", Value=2},
                new KeyValue<int>{ Key="جوزا", Value=3},
                new KeyValue<int>{ Key="سرطان", Value=4},
                new KeyValue<int>{ Key="اسد", Value=5},
                new KeyValue<int>{ Key="سنبله", Value=6},
                new KeyValue<int>{ Key="میزان", Value=7},
                new KeyValue<int>{ Key="عقرب", Value=8},
                new KeyValue<int>{ Key="قوس", Value=9},
                new KeyValue<int>{ Key="جدی", Value=10},
                new KeyValue<int>{ Key="دلو", Value=11},
                new KeyValue<int>{ Key="حوت", Value=12},
            };

            return result.ToList();
        }
        /// <summary>
        /// روز
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<KeyValue<int>> TitleValueDay()
        {
            var result = new List<KeyValue<int>>();
            for (var i = 1; i < 31; i++)
            {
                result.Add(new KeyValue<int>
                {
                    Key = ($"روز {i}"),
                    Value = i
                });
            }
            return result.ToList();
        }
    }
}
