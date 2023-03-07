using System.Collections.Generic;

namespace DataReader.Reader.Data
{
    /// <summary>
    /// Data1.
    /// </summary>
    public class Datas
    {
        /// <summary>
        /// Data1 rows.
        /// </summary>
        public IList<DataRow> Rows { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Datas()
        {
            Rows = new List<DataRow>();
        }
    }
}