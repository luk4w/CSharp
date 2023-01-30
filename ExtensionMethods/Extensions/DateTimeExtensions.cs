
using System.Globalization;

namespace Extensions
{
    public static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime dateTime)
        {
            TimeSpan duration = DateTime.Now.Subtract(dateTime);
            if (duration.TotalHours < 24)
                return $"{duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture)} hours";
            else
                return $"{duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture)} days";
        }
    }
}