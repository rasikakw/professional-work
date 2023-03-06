namespace Client.Models
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

        public string TransmissionStatusShort
        {
            get
            {
                string status = null;
                if (TransmissionStatus == MailTransmissionStatus.None)
                    status = "Unknown.";
                else if (TransmissionStatus == MailTransmissionStatus.Submitted)
                    status = "Submitted.";
                else if (TransmissionStatus == MailTransmissionStatus.InProgress)
                    status = "In progress.";
                else if (TransmissionStatus == MailTransmissionStatus.Delivered)
                    status = "Delivered.";
                else if (TransmissionStatus == MailTransmissionStatus.DeliveryFailed)
                    status = "Delivery failed.";
                return status;
            }
        }

        public string TransmissionStatusLong
        {
            get
            {
                string status = null;
                if (TransmissionStatus == MailTransmissionStatus.None)
                    status = "Unknown.";
                else if (TransmissionStatus == MailTransmissionStatus.Submitted)
                    status = "Mail submitted for transmission.";
                else if (TransmissionStatus == MailTransmissionStatus.InProgress)
                    status = "Mail transmission in progress.";
                else if (TransmissionStatus == MailTransmissionStatus.Delivered)
                    status = "Mail successfully delivered.";
                else if (TransmissionStatus == MailTransmissionStatus.DeliveryFailed)
                    status = "Mail delivery failed.";
                return status;
            }
        }
    }
}