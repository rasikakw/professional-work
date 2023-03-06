using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Client.Models;

namespace Client
{
    /// <summary>
    /// Main form.
    /// </summary>
    /// <permission>© 2021 Rasika Kavinda Wijayaratne.</permission>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        #region General.

        /// <summary>
        /// Sets status message.
        /// </summary>
        /// <param name="message">Status message.</param>
        private void SetStatus(string message)
        {
            mainStatusToolStripStatusLabel.Text = message;
        }

        /// <summary>
        /// Show about Client.
        /// </summary>
        private void ShowAboutClient()
        {
            SetStatus(string.Format("About {0}.", Constants.AppName));
            MessageBox.Show(this, string.Format("{0}.{1}{1}{2}", Constants.AppName, Environment.NewLine, Constants.CopyrightInfo), Constants.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetStatus(string.Format("About {0} closed.", Constants.AppName));
        }

        #endregion

        #region Mail.

        IEnumerable<MailMessage> _mails;

        /// <summary>
        /// Checks for mail from server.
        /// </summary>
        private async Task CheckMail()
        {
            SetStatus("Checking mail on server...");

            bool err = false;
            try
            {
                _mails = await WebApiClient.GetAllMailAsync();
            }
            catch (Exception exc)
            {
                SetStatus(Constants.ErrorMessagePrefix + exc.Message);
                err = true;
            }

            if (!err)
            {
                mailListView.Items.Clear();
                int mailCount = 0;
                if (_mails != null && _mails.Any())
                {
                    foreach (MailMessage mail in _mails)
                    {
                        mailListView.Items.Add(new ListViewItem(new string[] { mail.Id.ToString(), mail.FromEmail, mail.ToEmail, mail.Subject, mail.Message, mail.TransmissionStatusShort }));
                        mailCount++;
                    }
                }

                if (mailCount > 0)
                    SetStatus(string.Format("Checked mail, fetched {0} mails from server. Double-click on mails to view details.", mailCount));
                else
                    SetStatus("Checked mail, no mail on server.");
            }
        }

        /// <summary>
        /// Opens selected mail.
        /// </summary>
        private async Task OpenSelectedMail()
        {
            ListView.SelectedListViewItemCollection selItems = mailListView.SelectedItems;
            if (_mails != null && selItems != null && selItems.Count > 0)
            {
                int selMailId = 0;
                if (int.TryParse(selItems[0].Text, out selMailId))
                {
                    MailMessage selMail = _mails.Where(m => m.Id == selMailId).FirstOrDefault();
                    if (selMail != null)
                        await OpenMail(selMail);
                }
            }
        }

        /// <summary>
        /// Open mail.
        /// </summary>
        /// <param name="viewMail">Mail to view.</param>
        private async Task OpenMail(MailMessage viewMail)
        {
            if (viewMail == null)
                SetStatus("Compose mail.");
            else
                SetStatus(string.Format("View details for mail Id {0}.", viewMail.Id));

            MailForm mailForm = new MailForm();
            mailForm.ViewMail = viewMail;
            mailForm.EnableViewMode();

            DialogResult res = mailForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                SetStatus("Mail successfully sent.");
                await CheckMail();
            }
            else if (res == DialogResult.Cancel)
            {
                if (viewMail == null)
                    SetStatus("Compose mail cancelled.");
                else
                    SetStatus("View mail details closed.");
            }
        }

        /// <summary>
        /// Searches for mail.
        /// </summary>
        private async Task SearchMail()
        {
            int mailId = 0;
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                MessageBox.Show(this, "Mail Id cannot be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (!int.TryParse(searchTextBox.Text, out mailId))
                {
                    MessageBox.Show(this, "Mail Id must be an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            SetStatus(string.Format("Searching for mail with id {0} on server...", mailId));

            MailMessage mail = null;
            bool err = false;
            try
            {
                mail = await WebApiClient.GetMailAsync(mailId);
            }
            catch (Exception exc)
            {
                SetStatus(Constants.ErrorMessagePrefix + exc.Message);
                err = true;
            }

            if (!err)
            {
                if (mail != null)
                    await OpenMail(mail);
                else
                    SetStatus(string.Format("Unable to locate mail with id {0} on server.", mailId));
            }
        }

        #endregion

        #region Event handlers.

        /// <summary>
        /// Event handler.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private async void mailCheckMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await CheckMail();
        }

        /// <summary>
        /// Event handler.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private async void checkMailToolStripButton_Click(object sender, EventArgs e)
        {
            await CheckMail();
        }

        /// <summary>
        /// Event handler.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private async void mailComposeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await OpenMail(null);
        }

        /// <summary>
        /// Event handler.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private async void composeToolStripButton_Click(object sender, EventArgs e)
        {
            await OpenMail(null);
        }

        /// <summary>
        /// Event handler.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void helpAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAboutClient();
        }

        /// <summary>
        /// Event handler.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void fileExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Event handler.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private async void mailListView_DoubleClick(object sender, EventArgs e)
        {
            await OpenSelectedMail();
        }

        /// <summary>
        /// Event handler.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private async void searchButton_Click(object sender, EventArgs e)
        {
            await SearchMail();
        }

        /// <summary>
        /// Event handler.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            SetStatus(string.Format("{0} started.", Constants.AppName));
        }

        #endregion
    }
}