namespace Client
{
    partial class MailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailForm));
            this.mailFormGroupBox = new System.Windows.Forms.GroupBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.toEmailTextBox = new System.Windows.Forms.TextBox();
            this.toEmailLabel = new System.Windows.Forms.Label();
            this.fromEmailTextBox = new System.Windows.Forms.TextBox();
            this.fromEmailLabel = new System.Windows.Forms.Label();
            this.mailFormErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mailFormGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailFormErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // mailFormGroupBox
            // 
            this.mailFormGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mailFormGroupBox.Controls.Add(this.idTextBox);
            this.mailFormGroupBox.Controls.Add(this.idLabel);
            this.mailFormGroupBox.Controls.Add(this.statusLabel);
            this.mailFormGroupBox.Controls.Add(this.statusTextBox);
            this.mailFormGroupBox.Controls.Add(this.cancelButton);
            this.mailFormGroupBox.Controls.Add(this.sendButton);
            this.mailFormGroupBox.Controls.Add(this.messageTextBox);
            this.mailFormGroupBox.Controls.Add(this.messageLabel);
            this.mailFormGroupBox.Controls.Add(this.subjectTextBox);
            this.mailFormGroupBox.Controls.Add(this.subjectLabel);
            this.mailFormGroupBox.Controls.Add(this.toEmailTextBox);
            this.mailFormGroupBox.Controls.Add(this.toEmailLabel);
            this.mailFormGroupBox.Controls.Add(this.fromEmailTextBox);
            this.mailFormGroupBox.Controls.Add(this.fromEmailLabel);
            this.mailFormGroupBox.Location = new System.Drawing.Point(12, 12);
            this.mailFormGroupBox.Name = "mailFormGroupBox";
            this.mailFormGroupBox.Size = new System.Drawing.Size(390, 338);
            this.mailFormGroupBox.TabIndex = 0;
            this.mailFormGroupBox.TabStop = false;
            this.mailFormGroupBox.Text = "Compose Mail";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(77, 21);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(192, 20);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.Visible = false;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(10, 24);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(47, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Email Id:";
            this.idLabel.Visible = false;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(10, 279);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 10;
            this.statusLabel.Text = "Status:";
            this.statusLabel.Visible = false;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(77, 276);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(192, 20);
            this.statusTextBox.TabIndex = 11;
            this.statusTextBox.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(194, 302);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(113, 302);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 12;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(77, 130);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageTextBox.Size = new System.Drawing.Size(192, 140);
            this.messageTextBox.TabIndex = 9;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(10, 133);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(53, 13);
            this.messageLabel.TabIndex = 8;
            this.messageLabel.Text = "Message:";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(77, 101);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(192, 20);
            this.subjectTextBox.TabIndex = 7;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(10, 104);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(46, 13);
            this.subjectLabel.TabIndex = 6;
            this.subjectLabel.Text = "Subject:";
            // 
            // toEmailTextBox
            // 
            this.toEmailTextBox.Location = new System.Drawing.Point(77, 74);
            this.toEmailTextBox.Name = "toEmailTextBox";
            this.toEmailTextBox.Size = new System.Drawing.Size(192, 20);
            this.toEmailTextBox.TabIndex = 5;
            // 
            // toEmailLabel
            // 
            this.toEmailLabel.AutoSize = true;
            this.toEmailLabel.Location = new System.Drawing.Point(10, 77);
            this.toEmailLabel.Name = "toEmailLabel";
            this.toEmailLabel.Size = new System.Drawing.Size(51, 13);
            this.toEmailLabel.TabIndex = 4;
            this.toEmailLabel.Text = "To Email:";
            // 
            // fromEmailTextBox
            // 
            this.fromEmailTextBox.Location = new System.Drawing.Point(77, 47);
            this.fromEmailTextBox.Name = "fromEmailTextBox";
            this.fromEmailTextBox.Size = new System.Drawing.Size(192, 20);
            this.fromEmailTextBox.TabIndex = 3;
            // 
            // fromEmailLabel
            // 
            this.fromEmailLabel.AutoSize = true;
            this.fromEmailLabel.Location = new System.Drawing.Point(10, 50);
            this.fromEmailLabel.Name = "fromEmailLabel";
            this.fromEmailLabel.Size = new System.Drawing.Size(61, 13);
            this.fromEmailLabel.TabIndex = 2;
            this.fromEmailLabel.Text = "From Email:";
            // 
            // mailFormErrorProvider
            // 
            this.mailFormErrorProvider.ContainerControl = this;
            // 
            // MailForm
            // 
            this.AcceptButton = this.sendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(414, 362);
            this.Controls.Add(this.mailFormGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(430, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(430, 400);
            this.Name = "MailForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Compose Mail";
            this.mailFormGroupBox.ResumeLayout(false);
            this.mailFormGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailFormErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mailFormGroupBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.TextBox toEmailTextBox;
        private System.Windows.Forms.Label toEmailLabel;
        private System.Windows.Forms.TextBox fromEmailTextBox;
        private System.Windows.Forms.Label fromEmailLabel;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.ErrorProvider mailFormErrorProvider;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
    }
}