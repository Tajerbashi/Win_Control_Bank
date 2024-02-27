namespace Account.Application.Library.Models.FilterModel
{
    public class GridFilter
    {
        public string FromDatePersian { get; set; }
        public DateTime FromDateGregorian { get; set; }

        public string ToDatePersian { get; set; }
        public DateTime ToDateGregorian { get; set; }

        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public double FBlance { get; set; }
        public double TBlance { get; set; }
    }
}
