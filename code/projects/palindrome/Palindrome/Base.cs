namespace Palindrome
{
    /// <summary>
    /// Base.
    /// </summary>
    public class Base
    {
        Log _log = new Log();

        /// <summary>
        /// Logs information.
        /// </summary>
        /// <param name="information">Information to log.</param>
        internal void LogInformation(string information)
        {
            _log.LogInformation(information);
        }

        /// <summary>
        /// Logs warning.
        /// </summary>
        /// <param name="warning">Warning to log.</param>
        internal void LogWarning(string warning)
        {
            _log.LogWarning(warning);
        }

        /// <summary>
        /// Logs error.
        /// </summary>
        /// <param name="error">Error to log.</param>
        internal void LogError(string error)
        {
            _log.LogError(error);
        }
    }
}