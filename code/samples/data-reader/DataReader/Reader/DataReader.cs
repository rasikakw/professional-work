using System;
using System.Linq;
using System.IO;

using DataReader.Reader.Data;

namespace DataReader.Reader
{
    /// <summary>
    /// Log level.
    /// </summary>
    public enum LogLevel { All, Totals }

    /// <summary>
    /// Data reader.
    /// </summary>
    public class DataReader : AppBase
    {
        /// <summary>
        /// Reads data from a data file.
        /// </summary>
        /// <param name="dataFilePath">Path of data file to read.</param>
        /// <param name="skipRows">Number of rows to skip prior to reading.</param>
        /// <returns>Read data.</returns>
        public Datas ReadData(string dataFilePath, int skipRows)
        {
            if (string.IsNullOrWhiteSpace(dataFilePath))
                throw new ArgumentNullException(nameof(dataFilePath));
            if (!File.Exists(dataFilePath))
                throw new FileNotFoundException("Could not locate file at path: " + dataFilePath);

            string[] fileContRows = File.ReadAllLines(dataFilePath);
            Datas datas = new Datas();
            if (fileContRows != null && fileContRows.Length > 0)
            {
                int rowNo = 0;
                for (int i = 0; i < fileContRows.Length; i++)
                {
                    if (skipRows > 0 && i + 1 <= skipRows)
                        continue;

                    DataRow dataRow = new DataRow();
                    dataRow.RowNo = ++rowNo;

                    string[] row = fileContRows[i].Split(Constants.DataSepChar1);
                    if (row != null && row.Length > 0)
                    {
                        string cust = row[(int)DataRowColumns.Customer];
                        if (!string.IsNullOrWhiteSpace(cust))
                            dataRow.Customer = cust.Trim();

                        int total = 0;
                        int.TryParse(row[(int)DataRowColumns.Total], out total);
                        dataRow.Total = total;

                        string concRateTxt = row[(int)DataRowColumns.ConcentrationRate];
                        if (!string.IsNullOrWhiteSpace(concRateTxt))
                        {
                            concRateTxt = concRateTxt.Replace(Constants.PercChar1.ToString(), null);
                            int concRate = 0;
                            int.TryParse(concRateTxt, out concRate);
                            dataRow.ConcentrationRate = concRate;
                        }

                        int conc = 0;
                        int.TryParse(row[(int)DataRowColumns.Concentration], out conc);
                        dataRow.Concentration = conc;

                        int aged = 0;
                        int.TryParse(row[(int)DataRowColumns.Aged], out aged);
                        dataRow.Aged = aged;

                        int contras = 0;
                        int.TryParse(row[(int)DataRowColumns.Contras], out contras);
                        dataRow.Contras = contras;

                        int credNotes = 0;
                        int.TryParse(row[(int)DataRowColumns.CreditNotes], out credNotes);
                        dataRow.CreditNotes = credNotes;

                        int rel = 0;
                        int.TryParse(row[(int)DataRowColumns.Related], out rel);
                        dataRow.Related = rel;

                        int nonComm = 0;
                        int.TryParse(row[(int)DataRowColumns.NonCommercial], out nonComm);
                        dataRow.NonCommercial = nonComm;

                        int credRisk = 0;
                        int.TryParse(row[(int)DataRowColumns.CreditRisk], out credRisk);
                        dataRow.CreditRisk = credRisk;

                        int internat = 0;
                        int.TryParse(row[(int)DataRowColumns.International], out internat);
                        dataRow.International = internat;

                        int unsInv = 0;
                        int.TryParse(row[(int)DataRowColumns.UnsuitableInvoicing], out unsInv);
                        dataRow.UnsuitableInvoicing = unsInv;

                        int failVerif = 0;
                        int.TryParse(row[(int)DataRowColumns.FailedVerification], out failVerif);
                        dataRow.FailedVerification = failVerif;

                        int appr = 0;
                        int.TryParse(row[(int)DataRowColumns.Approved], out appr);
                        dataRow.Approved = appr;

                        string fundRateTxt = row[(int)DataRowColumns.FundingRate];
                        if (!string.IsNullOrWhiteSpace(fundRateTxt))
                        {
                            fundRateTxt = fundRateTxt.Replace(Constants.PercChar1.ToString(), null);
                            int fundRate = 0;
                            int.TryParse(fundRateTxt, out fundRate);
                            dataRow.FundingRate = fundRate;
                        }

                        int limit = 0;
                        int.TryParse(row[(int)DataRowColumns.Limit], out limit);
                        dataRow.Limit = limit;
                    }
                    datas.Rows.Add(dataRow);
                }
                _log.Log($"Processed {rowNo} row(s).");
            }
            return datas;
        }

        /// <summary>
        /// Logs data.
        /// </summary>
        /// <param name="datas">Data to log.</param>
        /// <param name="logLevel">Log level.</param>
        public void LogData(Datas datas, LogLevel logLevel = LogLevel.Totals)
        {
            if (datas == null || datas.Rows == null || datas.Rows.Count < 1)
                _log.LogWarning("No data to display.");
            if (logLevel == LogLevel.Totals)
            {
                //DataRow totRow = data.Rows[data.Rows.Count - 1];
                DataRow totRow = datas.Rows.Where(d => d.Customer == null).FirstOrDefault();
                if (totRow == null)
                    _log.LogError("Could not locate totals row.");
                else
                    LogDataRow(totRow);
            }
            else
                foreach (DataRow dataRow in datas.Rows)
                    LogDataRow(dataRow, true, true);
        }

        /// <summary>
        /// Logs data row.
        /// </summary>
        /// <param name="dataRow">Data row to log.</param>
        /// <param name="displayRowNo">Whether to display row number.</param>
        /// <param name="displayCustomer">Whether to display customer.</param>
        private void LogDataRow(DataRow dataRow, bool displayRowNo = false, bool displayCustomer = false)
        {
            if (dataRow == null)
                _log.LogWarning("No row data to display.");

            if (displayRowNo)
                _log.Log($"Row #: {dataRow.RowNo}");
            if (displayCustomer)
                _log.Log($"Customer: {dataRow.Customer}");
            _log.Log($"Total: {dataRow.Total}");
            _log.Log($"Concentration Rate: {dataRow.ConcentrationRate}");
            _log.Log($"Concentration: {dataRow.Concentration}");
            _log.Log($"Aged: {dataRow.Aged}");
            _log.Log($"Contras: {dataRow.Contras}");
            _log.Log($"Credit Notes: {dataRow.CreditNotes}");
            _log.Log($"Related: {dataRow.Related}");
            _log.Log($"Non-Commercial: {dataRow.NonCommercial}");
            _log.Log($"Credit Risk: {dataRow.CreditRisk}");
            _log.Log($"International: {dataRow.International}");
            _log.Log($"Unsuitable Invoicing: {dataRow.UnsuitableInvoicing}");
            _log.Log($"Failed Verification: {dataRow.FailedVerification}");
            _log.Log($"Approved: {dataRow.Approved}");
            _log.Log($"FundingRate: {dataRow.FundingRate}");
            _log.Log($"Limit: {dataRow.Limit}{Environment.NewLine}");
        }
    }
}