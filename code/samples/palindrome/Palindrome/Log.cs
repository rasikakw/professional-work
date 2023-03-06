using System;

namespace Palindrome
{
    /// <summary>
    /// Log.
    /// </summary>
    internal class Log
    {
        const string InformationPrefix = "Information: ";
        const string WarningPrefix = "Warning: ";
        const string ErrorPrefix = "Error: ";

        /// <summary>
        /// Logs information.
        /// </summary>
        /// <param name="information">Information to log.</param>
        internal void LogInformation(string information)
        {
            if (string.IsNullOrWhiteSpace(information))
                return;
            Console.WriteLine(InformationPrefix + information);
        }

        /// <summary>
        /// Logs warning.
        /// </summary>
        /// <param name="warning">Warning to log.</param>
        internal void LogWarning(string warning)
        {
            if (string.IsNullOrWhiteSpace(warning))
                return;
            Console.WriteLine(WarningPrefix + warning);
        }

        /// <summary>
        /// Logs error.
        /// </summary>
        /// <param name="error">Error to log.</param>
        internal void LogError(string error)
        {
            if (string.IsNullOrWhiteSpace(error))
                return;
            Console.WriteLine(ErrorPrefix + error);
        }
    }
}