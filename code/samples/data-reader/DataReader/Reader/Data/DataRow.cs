namespace DataReader.Reader.Data
{
    /// <summary>
    /// Data1Row columns.
    /// </summary>
    public enum DataRowColumns
    {
        Customer,
        Total,
        ConcentrationRate,
        Concentration,
        Aged,
        Contras,
        CreditNotes,
        Related,
        NonCommercial,
        CreditRisk,
        International,
        UnsuitableInvoicing,
        FailedVerification,
        Approved,
        FundingRate,
        Limit,
        RowNo
    }

    /// <summary>
    /// Data1 row.
    /// </summary>
    public class DataRow
    {
        /// <summary>
        /// Customer.
        /// </summary>
        public string Customer { get; set; } = null;

        /// <summary>
        /// Total.
        /// </summary>
        public int Total { get; set; } = 0;

        /// <summary>
        /// Concentration rate.
        /// </summary>
        public int ConcentrationRate { get; set; } = 0;

        /// <summary>
        /// Concentration.
        /// </summary>
        public int Concentration { get; set; } = 0;

        /// <summary>
        /// Aged.
        /// </summary>
        public int Aged { get; set; } = 0;

        /// <summary>
        /// Contras.
        /// </summary>
        public int Contras { get; set; } = 0;

        /// <summary>
        /// Credit notes.
        /// </summary>
        public int CreditNotes { get; set; } = 0;

        /// <summary>
        /// Related.
        /// </summary>
        public int Related { get; set; } = 0;

        /// <summary>
        /// Non-commercial.
        /// </summary>
        public int NonCommercial { get; set; } = 0;

        /// <summary>
        /// Credit risk.
        /// </summary>
        public int CreditRisk { get; set; } = 0;

        /// <summary>
        /// International.
        /// </summary>
        public int International { get; set; } = 0;

        /// <summary>
        /// Unsuitable invoicing.
        /// </summary>
        public int UnsuitableInvoicing { get; set; } = 0;

        /// <summary>
        /// Failed verification.
        /// </summary>
        public int FailedVerification { get; set; } = 0;

        /// <summary>
        /// Approved.
        /// </summary>
        public int Approved { get; set; } = 0;

        /// <summary>
        /// Funding rate.
        /// </summary>
        public int FundingRate { get; set; } = 0;

        /// <summary>
        /// Limit.
        /// </summary>
        public int Limit { get; set; } = 0;

        /// <summary>
        /// Row number.
        /// </summary>
        public int RowNo { get; set; } = 0;
    }
}