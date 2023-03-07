using System;

namespace DataReader.Utility
{
    /// <summary>
    /// Log type.
    /// </summary>
    public enum LogType { Information, Warning, Error }

    /// <summary>
    /// Logger.
    /// </summary>
    public class Logger
    {
        private const string WarnPref = "Warning: ";
        private const string ErrPref = "Error: ";

        /// <summary>
        /// Logs message.
        /// </summary>
        /// <param name="message">Message to log.</param>
        /// <param name="logType">Log type.</param>
        public void Log(string message = null, LogType logType = LogType.Information)
        {
            switch(logType)
            {
                case LogType.Information:
                    LogInformation(message);
                    break;
                case LogType.Warning:
                    LogWarning(message);
                    break;
                case LogType.Error:
                    LogError(message);
                    break;
            }
        }

        /// <summary>
        /// Logs information.
        /// </summary>
        /// <param name="information">Information to log.</param>
        public void LogInformation(string information = null)
        {
            Console.WriteLine(information);
        }

        /// <summary>
        /// Logs warning.
        /// </summary>
        /// <param name="warning">Warning to log.</param>
        public void LogWarning(string warning = null)
        {
            Console.WriteLine(WarnPref + warning);
        }

        /// <summary>
        /// Logs error.
        /// </summary>
        /// <param name="error">Error to log.</param>
        public void LogError(string error = null)
        {
            Console.WriteLine(ErrPref + error);
        }
    }
}