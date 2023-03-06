namespace Mail.Models
{
    /// <summary>
    /// Mail transmission status.
    /// </summary>
    /// <permission>© 2021 Rasika Kavinda Wijayaratne.</permission>
    public enum MailTransmissionStatus
    {
        None,
        Submitted,
        InProgress,
        Delivered,
        DeliveryFailed
    }

    /// <summary>
    /// Mail message.
    /// </summary>
    /// <permission>© 2021 Rasika Kavinda Wijayaratne.</permission>
    public class MailMessage
    {
        public int Id { get; set; }
        public string FromEmail { get; set; }
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public MailTransmissionStatus TransmissionStatus { get; set; }
    }
}
