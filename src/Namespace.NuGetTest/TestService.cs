using System;

namespace Empyrean.ApprovalApiClient
{
    /// <summary>
    /// Implement a TestService.
    /// </summary>
    public static class TestService
    {
        /// <summary>
        /// Gets the time.
        /// </summary>
        /// <returns></returns>
        public static DateTime GetTime()
        {
            return DateTime.UtcNow;
        }
    }
}