using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SportData.Utils
{
    public static class DateTimeExtensions
    {
        public static string ToShortMonthName(this DateTime date)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(date.Month);
        }

        public static string ToMonthName(this DateTime date)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(date.Month);
        }
    }
}
