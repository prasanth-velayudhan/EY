using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Common.Helpers
{
    public static class DateTimeHelper
    {
        /// <summary>
        /// Returns start of the day at midnight 0:00
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime StartOfDay(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day);
        }

        /// <summary>
        /// Returns end of the day at 23:59:59
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime EndOfDay(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day).AddDays(1).AddSeconds(-1);
        }

        /// <summary>
        /// Returns start of the month at midnight 0:00
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime StartOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }

        /// <summary>
        /// Returns end of the month at 23:59:59
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime EndOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1).AddMonths(1).AddSeconds(-1); 
        }

        /// <summary>
        /// Checks if a date range overlaps with another.  Null dates are considered to be +/- infinity
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="startDateToCompare"></param>
        /// <param name="endDateToCompare"></param>
        /// <returns></returns>
        public static bool DatesOverlap(DateTime? startDate, DateTime? endDate, DateTime startDateToCompare, DateTime endDateToCompare)
        {
            return (!startDate.HasValue || startDate.Value < endDateToCompare) && (!endDate.HasValue || startDateToCompare <= endDate.Value);
        }

        public static bool IsInRange(this DateTime date, DateTime startDateToCompare, DateTime endDateToCompare)
        {
            return DatesOverlap(date, date, startDateToCompare, endDateToCompare);
        }
    }
}
