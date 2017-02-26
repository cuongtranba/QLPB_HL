using System;

namespace _4.Helper
{
    public static class DateTimeExtentions
    {
        /// <summary>
        /// Get first day of month
        /// </summary>
        /// <param name="sPeriod">format is yyyyMM</param>
        /// <returns></returns>
        public static DateTime FirstDayOfPeriod(this string sPeriod)
        {
            if (sPeriod == "")
                return DateTime.MinValue;
            int yyyy = int.Parse(sPeriod.Substring(0, 4));
            int mm = int.Parse(sPeriod.Substring(4, 2));
            DateTime dtime = new DateTime(yyyy, mm, 01);
            return dtime;
        }
        /// <summary>
        /// Get last day of month
        /// </summary>
        /// <param name="sPeriod">format is yyyyMM</param>
        /// <returns></returns>
        public static DateTime LastDayOfPeriod(this string sPeriod)
        {
            if (sPeriod == "")
                return DateTime.MinValue;
            int yyyy = int.Parse(sPeriod.Substring(0, 4));
            int mm = int.Parse(sPeriod.Substring(4, 2));
            int dd = 30;
            switch (mm)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    dd = 31;
                    break;
                case 2:
                    {
                        dd = 28;
                        if ((yyyy % 4 == 0 && yyyy % 100 != 0)
                            || (yyyy % 100 == 0 && yyyy % 400 == 0))
                            dd = 29;
                    }
                    break;
            }
            DateTime dtime = new DateTime(yyyy, mm, dd);
            return dtime;
        }

        public static string PeriodToStringVN(string sPeriod)
        {
            DateTime dtime = FirstDayOfPeriod(sPeriod);
            return dtime.ToString("Tháng MM/yyyy");
        }
    }
}
