using DataReader.Utility;

namespace DataReader
{
    /// <summary>
    /// Application base.
    /// </summary>
    public class AppBase
    {
        protected Logger _log;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public AppBase()
        {
            _log = new Logger();
        }
    }
}