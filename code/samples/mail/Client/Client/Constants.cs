namespace Client
{
    /// <summary>
    /// Constants.
    /// </summary>
    /// <permission>© 2021 Rasika Kavinda Wijayaratne.</permission>
    public class Constants
    {
        public const string WebApiMailPath = "http://localhost:2044/api/mail/";

        public const string CopyrightInfo = "© 2021 Rasika Kavinda Wijayaratne.";
        public const string AppName = "Client";
        public const string ErrorMessageTitle = "Error"; 
        public const string ErrorMessagePrefix = "Error: "; 
        public const string MailBlankMailSubject = "(No Subject)";

        public const string RegExEmail = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
    }
}