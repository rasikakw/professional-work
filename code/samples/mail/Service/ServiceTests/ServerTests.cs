using System.Collections.Generic;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Mail;
using Mail.Models;

namespace Service.Tests
{
    /// <summary>
    /// Server tests.
    /// </summary>
    /// <permission>© 2021 Rasika Kavinda Wijayaratne.</permission>
    [TestClass]
    public class ServerTests
    {
        MailServer _mailServ;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public ServerTests()
        {
            _mailServ = new MailServer();
        }

        /// <summary>
        /// Tests Mail.MailServer.GetAllMail.
        /// </summary>
        [TestMethod]
        public void Test_GetAllMail1()
        {
            IEnumerable<MailMessage> mails = _mailServ.GetAllMail();
            Assert.IsNotNull(mails);
            Assert.IsTrue(mails.Any());
        }

        /// <summary>
        /// Tests Mail.MailServer.SendMail and Mail.MailServer.GetMail.
        /// </summary>
        [TestMethod]
        public void Test_SendMail1()
        {
            const string fromAddr = "test1@test.com";
            const string toAddr = "test2@test.com";

            MailMessage mail = new MailMessage { FromEmail = fromAddr, ToEmail = toAddr };
            Assert.IsTrue(mail.TransmissionStatus == MailTransmissionStatus.None);

            MailMessage sentMail = _mailServ.SendMail(mail);

            MailMessage sentMailServer = _mailServ.GetMail(sentMail.Id);
            Assert.IsNotNull(sentMailServer);
            Assert.IsTrue(sentMailServer.Id == sentMail.Id);
            Assert.IsTrue(sentMailServer.TransmissionStatus != MailTransmissionStatus.None);
        }
    }
}