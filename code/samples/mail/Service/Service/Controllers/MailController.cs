using System.Collections.Generic;
using System.Web.Http;

using Mail;
using Mail.Models;

namespace Service.Controllers
{
    /// <summary>
    /// Mail controller.
    /// </summary>
    /// <permission>© 2021 Rasika Kavinda Wijayaratne.</permission>
    public class MailController : ApiController
    {
        MailServer _mailServ;

        /// <summary>
        /// Default constructor.
        /// </summary>
        MailController()
        {
            _mailServ = new MailServer();
        }

        // GET: api/Mail
        /// <summary>
        /// Gets all mails in the mailing system.
        /// </summary>
        /// <returns>All mails.</returns>
        public IEnumerable<MailMessage> Get()
        {
            return _mailServ.GetAllMail();
        }

        // GET: api/Mail/5
        /// <summary>
        /// Gets a single mail by its Id.
        /// </summary>
        /// <param name="id">Id of mail to get.</param>
        /// <returns>Matching mail.</returns>
        public MailMessage Get(int id)
        {
            return _mailServ.GetMail(id);
        }

        // POST: api/Mail
        /// <summary>
        /// Sends a single mail.
        /// </summary>
        /// <param name="mail">Mail to send.</param>
        /// <returns>Id of sent mail.</returns>
        public int Post([FromBody]MailMessage mail)
        {
            MailMessage sentMail = _mailServ.SendMail(mail);
            return sentMail.Id;
        }

        // PUT: api/Mail/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Mail/5
        public void Delete(int id)
        {
        }
    }
}