using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

using Client.Models;

namespace Client
{
    /// <summary>
    /// Web API client.
    /// </summary>
    /// <permission>© 2021 Rasika Kavinda Wijayaratne.</permission>
    public class WebApiClient
    {
        static HttpClient _httpClient = new HttpClient();
        static string webApiMailPath = Constants.WebApiMailPath;

        /// <summary>
        /// Gets all mail on server.
        /// </summary>
        /// <returns>All mail on server.</returns>
        public static async Task<IEnumerable<MailMessage>> GetAllMailAsync()
        {
            IEnumerable<MailMessage> mails = null;
            HttpResponseMessage resp = await _httpClient.GetAsync(webApiMailPath);
            if (resp.IsSuccessStatusCode)
                mails = await resp.Content.ReadAsAsync<IEnumerable<MailMessage>>();
            return mails;
        }

        /// <summary>
        /// Gets a single mail by its Id.
        /// </summary>
        /// <param name="mailId">Id of mail to get.</param>
        /// <returns>Matching mail.</returns>
        public static async Task<MailMessage> GetMailAsync(int mailId)
        {
            if (mailId < 1)
                throw new ArgumentOutOfRangeException(nameof(mailId));
            MailMessage mail = null;
            HttpResponseMessage resp = await _httpClient.GetAsync(webApiMailPath + mailId);
            if (resp.IsSuccessStatusCode)
                mail = await resp.Content.ReadAsAsync<MailMessage>();
            return mail;
        }

        /// <summary>
        /// Sends a single mail.
        /// </summary>
        /// <param name="mail">Mail to send.</param>
        /// <returns>Id of sent mail.</returns>
        public static async Task<int> SendMail(MailMessage mail)
        {
            if (mail == null)
                throw new ArgumentNullException(nameof(mail));
            HttpResponseMessage resp = await _httpClient.PostAsJsonAsync(webApiMailPath, mail);
            int newMailId = 0;
            if (resp.IsSuccessStatusCode)
                newMailId = await resp.Content.ReadAsAsync<int>();
            return newMailId;
        }
    }
}