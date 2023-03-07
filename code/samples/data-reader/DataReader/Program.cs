using System;

using DataReader.Reader.Data;
using DataReader.Utility;

namespace DataReader
{
    /// <summary>
    /// Application.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Application entry point.
        /// </summary>
        /// <param name="args">Application arguments.</param>
        static void Main(string[] args)
        {
            Logger log = new Logger();
            try
            {
                string dataFilePath = Utility.Utility.GetDataFilePath();
                Reader.DataReader dr = new Reader.DataReader();
                Datas datas = dr.ReadData(dataFilePath, Constants.DataSkipRows);

                log.Log();
                log.Log("Displaying totals data:");
                log.Log();
                dr.LogData(datas);

                // Enable to display all rows.
                bool displayAllRows = true;
                if (displayAllRows)
                {
                    log.Log();
                    log.Log("Displaying all row data:");
                    log.Log();
                    dr.LogData(datas, Reader.LogLevel.All);
                }
            }
            catch (Exception exc)
            {
                log.LogError("Caught exception: " + exc);
            }

            Console.ReadLine();
        }
    }
}