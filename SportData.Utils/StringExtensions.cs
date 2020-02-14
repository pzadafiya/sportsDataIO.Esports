using System;
using System.Collections.Generic;
using System.Text;

namespace SportData.Utils
{
    public static class StringExtensions
    {
        public static string ToApiDate(this DateTime date)
        {
            return string.Format("{0}-{1}-{2:D2}", date.Year, date.ToShortMonthName().ToUpper(), date.Day);
        }
    }
}
