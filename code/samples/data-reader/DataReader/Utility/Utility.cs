using System.IO;
using System.Reflection;

namespace DataReader.Utility
{
    /// <summary>
    /// Utility.
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Gets application path.
        /// </summary>
        /// <returns>Application path.</returns>
        public static string GetAppPath()
        {
            string path = Assembly.GetExecutingAssembly().Location;
            path = path.Substring(0, path.LastIndexOf(Path.DirectorySeparatorChar) + 1);
            return path;
        }

        /// <summary>
        /// Gets Data1 file path.
        /// </summary>
        /// <returns>Data1 file path.</returns>
        public static string GetDataFilePath()
        {
            string path = GetAppPath() + Constants.DataFileName;
            return path;
        }
    }
}