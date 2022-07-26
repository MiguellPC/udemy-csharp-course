using System.Globalization;

namespace System
{
    internal static class DateTimeExtensions
    {
        public static string TimeElapsed(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalSeconds < 60.0)
            {
                return duration.Seconds + " seconds";
            }
            else if (duration.TotalMinutes < 60.0)
            {
                return duration.Minutes + " minutes " + duration.Seconds + " seconds";
            }
            else if (duration.TotalHours < 24.0)
            {
                return duration.Hours + " hours " + duration.Minutes + " minutes " + duration.Seconds + " seconds";
            }
            else
            {
                return duration.Days + " days " + duration.Hours + " hours " + duration.Minutes + " minutes " + duration.Seconds + " seconds";
            }
        }
    }
}
