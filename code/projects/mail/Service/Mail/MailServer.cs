using System;
using System.Collections.Generic;
using System.Linq;

using Mail.Models;

namespace Mail
{
    /// <summary>
    /// Mail provider.
    /// </summary>
    /// <permission>© 2021 Rasika Kavinda Wijayaratne.</permission>
    public class MailServer
    {
        static int _lastMailId = 1;
        static IList<MailMessage> _mails = new List<MailMessage>();

        /// <summary>
        /// Default constructor.
        /// </summary>
        public MailServer()
        {
            InitMails();
        }

        /// <summary>
        /// Gets all mail in the mailing system.
        /// </summary>
        /// <returns>All mail.</returns>
        public IEnumerable<MailMessage> GetAllMail()
        {
            return _mails;
        }

        /// <summary>
        /// Gets a single mail by its Id.
        /// </summary>
        /// <param name="id">Id of mail to get.</param>
        /// <returns>Matching mail.</returns>
        public MailMessage GetMail(int id)
        {
            if (id < 1)
                throw new ArgumentOutOfRangeException(nameof(id));

            return _mails.Where(m => m.Id == id).FirstOrDefault();
        }

        /// <summary>
        /// Sends mail.
        /// </summary>
        /// <param name="mail">Mail to send.</param>
        /// <returns>Id of sent mail.</returns>
        public MailMessage SendMail(MailMessage mail)
        {
            if (mail == null)
                throw new ArgumentNullException(nameof(mail));

            mail.Id = GetNextMailId();
            mail.TransmissionStatus = MailTransmissionStatus.Submitted;
            _mails.Add(mail);

            return mail;
        }

        /// <summary>
        /// Intialises mails.
        /// </summary>
        private void InitMails()
        {
            if (_mails.Count < 1)
            {
                _mails.Add(new MailMessage { Id = GetNextMailId(), FromEmail = "user1@organization1.com", ToEmail = "user2@organization2.com", Subject = "Subject 1", Message = " Message 1", TransmissionStatus = MailTransmissionStatus.Delivered });
                _mails.Add(new MailMessage { Id = GetNextMailId(), FromEmail = "user3@organization3.com", ToEmail = "user4@organization4.com", Subject = "Subject 2", Message = " Message 2", TransmissionStatus = MailTransmissionStatus.InProgress });
                _mails.Add(new MailMessage { Id = GetNextMailId(), FromEmail = "user5@organization5.com", ToEmail = "user6@organization6.com", Subject = "Subject 3", Message = " Message 3", TransmissionStatus = MailTransmissionStatus.Submitted });
            }
        }

        /// <summary>
        /// Gets next mail Id.
        /// </summary>
        /// <returns>Next mail Id.</returns>
        private int GetNextMailId()
        {
            return _lastMailId++;
        }

        /// <summary>
        /// Deletes mail from system.
        /// </summary>
        /// <param name="id">Id of mail to delete.</param>
        private void Delete(int id)
        {
            if (id < 1)
                throw new ArgumentOutOfRangeException(nameof(id));

            MailMessage mail = GetMail(id);

            if (mail != null)
                _mails.Remove(mail);
        }
    }
}