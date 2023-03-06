using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using Client.Models;

namespace Client
{
    /// <summary>
    /// Mail form.
    /// </summary>
    /// <permission>© 2021 Rasika Kavinda Wijayaratne.</permission>
    public partial class MailForm : Form
    {
        public MailMessage ViewMail { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public MailForm()
        {
            InitializeComponent();
        }

        #region General.

        /// <summary>
        /// Enables view mode.
        /// </summary>
        public void EnableViewMode()
        {
            if (ViewMail != null)
            {
                Text = "View Mail";
                mailFormGroupBox.Text = "View Mail";

                idLabel.Visible = true;
                idTextBox.Visible = true;
                idTextBox.Text = ViewMail.Id.ToString();

                fromEmailTextBox.ReadOnly = true;
                fromEmailTextBox.Text = ViewMail.FromEmail;

                toEmailTextBox.ReadOnly = true;
                toEmailTextBox.Text = ViewMail.ToEmail;

                subjectTextBox.ReadOnly = true;
                subjectTextBox.Text = ViewMail.Subject;

                messageTextBox.ReadOnly = true;
                messageTextBox.Text = ViewMail.Message;

                sendButton.Visible = false;
                cancelButton.Text = "Close";

                statusLabel.Visible = true;
                statusTextBox.Visible = true;
                statusTextBox.Text = ViewMail.TransmissionStatusLong;
            }
        }

        private void CloseForm()
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        #endregion

        #region Mail.

        /// <summary>
        /// Sends mail.
        /// </summary>
        private async Task SendMail()
        {
            bool isFromEmailErr = false;
            bool isToEmailErr = false;
            bool isSubjectErr = false;
            bool isMessageErr = false;

            if (string.IsNullOrWhiteSpace(fromEmailTextBox.Text))
            {
                mailFormErrorProvider.SetError(fromEmailTextBox, "From Email is required.");
                isFromEmailErr = true;
            }
            else
            {
                mailFormErrorProvider.SetError(fromEmailTextBox, null);
                isFromEmailErr = false;
            }

            if (!isFromEmailErr)
            {
                if (!Regex.IsMatch(fromEmailTextBox.Text, Constants.RegExEmail))
                {
                    mailFormErrorProvider.SetError(fromEmailTextBox, "From Email is not a valid email address.");
                    isFromEmailErr = true;
                }
                else
                {
                    mailFormErrorProvider.SetError(fromEmailTextBox, null);
                    isFromEmailErr = false;
                }
            }

            if (string.IsNullOrWhiteSpace(toEmailTextBox.Text))
            {
                mailFormErrorProvider.SetError(toEmailTextBox, "To Email is required.");
                isToEmailErr = true;
            }
            else
            {
                mailFormErrorProvider.SetError(toEmailTextBox, null);
                isToEmailErr = false;
            }

            if (!isToEmailErr)
            {
                if (!Regex.IsMatch(toEmailTextBox.Text, Constants.RegExEmail))
                {
                    mailFormErrorProvider.SetError(toEmailTextBox, "To Email is not a valid email address.");
                    isToEmailErr = true;
                }
                else
                {
                    mailFormErrorProvider.SetError(toEmailTextBox, null);
                    isToEmailErr = false;
                }
            }

            /*if (string.IsNullOrWhiteSpace(subjectTextBox.Text))
            {
                mailFormErrorProvider.SetError(subjectTextBox, "Subject is required.");
                isSubjectErr = true;
            }
            else
            {
                mailFormErrorProvider.SetError(subjectTextBox, null);
                isSubjectErr = false;
            }*/

            if (string.IsNullOrWhiteSpace(messageTextBox.Text))
            {
                mailFormErrorProvider.SetError(messageTextBox, "Message is required.");
                isMessageErr = true;
            }
            else
            {
                mailFormErrorProvider.SetError(messageTextBox, null);
                isMessageErr = false;
            }

            if (!isFromEmailErr && !isToEmailErr && !isSubjectErr && !isMessageErr)
            {
                DialogResult res = DialogResult.Yes;
                if (string.IsNullOrWhiteSpace(subjectTextBox.Text))
                    res = MessageBox.Show(this, "Send mail without Subject?", "No Subject", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    MailMessage mail = new MailMessage();
                    mail.FromEmail = fromEmailTextBox.Text.Trim();
                    mail.ToEmail = toEmailTextBox.Text.Trim();
                    if (!string.IsNullOrWhiteSpace(subjectTextBox.Text))
                        mail.Subject = subjectTextBox.Text.Trim();
                    else
                        mail.Subject = Constants.MailBlankMailSubject;
                    mail.Message = messageTextBox.Text.Trim();

                    int newMailId = 0;
                    bool err = false;
                    try
                    {
                        newMailId = await WebApiClient.SendMail(mail);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(this, exc.Message, Constants.ErrorMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        err = true;
                    }

                    if (!err)
                    {
                        MessageBox.Show(this, string.Format("Successfully sent mail, new mail id is {0}.", newMailId), Constants.ErrorMessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
            }
        }

        #endregion

        #region Event handlers.

        /// <summary>
        /// Event handler.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private async void sendButton_Click(object sender, EventArgs e)
        {
            await SendMail();
        }

        /// <summary>
        /// Event handler.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        #endregion
    }
}
