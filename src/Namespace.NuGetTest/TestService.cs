using System;

namespace Empyrean.ApprovalApiClient
{
    /// <summary>
    /// Implement a TestService.
    /// </summary>
    public static class TestService
    {
        /// <summary>
        /// Gets the current UTC time.
        /// </summary>
        /// <returns>
        /// The current UTC time.
        /// </returns>
        public static DateTime GetTime()
        {
            return DateTime.UtcNow;
        }

        /// <summary>
        /// Gets the time zone for a given date time.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        /// <returns>The time zone</returns>
        public static string GetTimeZone(DateTime dateTime)
        {
            return dateTime.Kind.ToString();
        }
    }
}