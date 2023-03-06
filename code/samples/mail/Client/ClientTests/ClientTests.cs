using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Client;
using Client.Models;

namespace ClientTests
{
    /// <summary>
    /// Client tests.
    /// </summary>
    /// <remarks>Service must be running.</remarks>
    /// <permission>© 2021 Rasika Kavinda Wijayaratne.</permission>
    [TestClass]
    public class ClientTests
    {
        /// <summary>
        /// Tests Client.WebApiClient.GetAllMailAsync.
        /// </summary>
        [TestMethod]
        public async Task Test_GetAllMail1()
        {
            IEnumerable<MailMessage> mails = await WebApiClient.GetAllMailAsync();
            Assert.IsNotNull(mails);
            Assert.IsTrue(mails.Any());
        }

        /// <summary>
        /// Tests Client.WebApiClient.SendMail and Client.WebApiClient.GetMailAsync.
        /// </summary>
        [TestMethod]
        public async Task Test_SendMail1()
        {
            const string fromAddr = "test1@test.com";
            const string toAddr = "test2@test.com";

            MailMessage mail = new MailMessage { FromEmail = fromAddr, ToEmail = toAddr };
            Assert.IsTrue(mail.TransmissionStatus == MailTransmissionStatus.None);

            int sentMailId = await WebApiClient.SendMail(mail);

            MailMessage sentMail = await WebApiClient.GetMailAsync(sentMailId);
            Assert.IsNotNull(sentMail);
            Assert.IsTrue(sentMail.Id == sentMailId);
            Assert.IsTrue(sentMail.TransmissionStatus != MailTransmissionStatus.None);
        }
    }
}