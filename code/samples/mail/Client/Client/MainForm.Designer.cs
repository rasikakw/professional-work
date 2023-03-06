namespace Client
{
    partial class MainForm
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
            System.Windows.Forms.ColumnHeader mailIdcolumnHeader;
            System.Windows.Forms.ColumnHeader fromEmailColumnHeader;
            System.Windows.Forms.ColumnHeader toEmailColumnHeader;
            System.Windows.Forms.ColumnHeader mailTransmissionStatusColumnHeader;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mailListView = new System.Windows.Forms.ListView();
            this.subjectColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.messageColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailComposeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailCheckMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mianStatusStrip = new System.Windows.Forms.StatusStrip();
            this.mainStatusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.composeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.checkMailToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            mailIdcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            fromEmailColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            toEmailColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            mailTransmissionStatusColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainMenuStrip.SuspendLayout();
            this.mianStatusStrip.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mailIdcolumnHeader
            // 
            mailIdcolumnHeader.Text = "Id";
            // 
            // fromEmailColumnHeader
            // 
            fromEmailColumnHeader.Text = "From Email";
            fromEmailColumnHeader.Width = 115;
            // 
            // toEmailColumnHeader
            // 
            toEmailColumnHeader.Text = "To Email";
            toEmailColumnHeader.Width = 115;
            // 
            // mailTransmissionStatusColumnHeader
            // 
            mailTransmissionStatusColumnHeader.Text = "Status";
            mailTransmissionStatusColumnHeader.Width = 85;
            // 
            // mailListView
            // 
            this.mailListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mailListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            mailIdcolumnHeader,
            fromEmailColumnHeader,
            toEmailColumnHeader,
            this.subjectColumnHeader1,
            this.messageColumnHeader,
            mailTransmissionStatusColumnHeader});
            this.mailListView.FullRowSelect = true;
            this.mailListView.GridLines = true;
            this.mailListView.Location = new System.Drawing.Point(12, 79);
            this.mailListView.Name = "mailListView";
            this.mailListView.Size = new System.Drawing.Size(687, 379);
            this.mailListView.TabIndex = 5;
            this.mailListView.UseCompatibleStateImageBehavior = false;
            this.mailListView.View = System.Windows.Forms.View.Details;
            this.mailListView.DoubleClick += new System.EventHandler(this.mailListView_DoubleClick);
            // 
            // subjectColumnHeader1
            // 
            this.subjectColumnHeader1.Text = "Subject";
            this.subjectColumnHeader1.Width = 130;
            // 
            // messageColumnHeader
            // 
            this.messageColumnHeader.Text = "Message";
            this.messageColumnHeader.Width = 170;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mailToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(711, 24);
            this.mainMenuStrip.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // fileExitToolStripMenuItem
            // 
            this.fileExitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileExitToolStripMenuItem.Image")));
            this.fileExitToolStripMenuItem.Name = "fileExitToolStripMenuItem";
            this.fileExitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.fileExitToolStripMenuItem.Text = "Exit";
            this.fileExitToolStripMenuItem.Click += new System.EventHandler(this.fileExitToolStripMenuItem_Click);
            // 
            // mailToolStripMenuItem
            // 
            this.mailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mailComposeToolStripMenuItem,
            this.mailCheckMailToolStripMenuItem});
            this.mailToolStripMenuItem.Name = "mailToolStripMenuItem";
            this.mailToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.mailToolStripMenuItem.Text = "Mail";
            // 
            // mailComposeToolStripMenuItem
            // 
            this.mailComposeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mailComposeToolStripMenuItem.Image")));
            this.mailComposeToolStripMenuItem.Name = "mailComposeToolStripMenuItem";
            this.mailComposeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.mailComposeToolStripMenuItem.Text = "Compose";
            this.mailComposeToolStripMenuItem.Click += new System.EventHandler(this.mailComposeToolStripMenuItem_Click);
            // 
            // mailCheckMailToolStripMenuItem
            // 
            this.mailCheckMailToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mailCheckMailToolStripMenuItem.Image")));
            this.mailCheckMailToolStripMenuItem.Name = "mailCheckMailToolStripMenuItem";
            this.mailCheckMailToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.mailCheckMailToolStripMenuItem.Text = "Check Mail";
            this.mailCheckMailToolStripMenuItem.Click += new System.EventHandler(this.mailCheckMailToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpAboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpAboutToolStripMenuItem
            // 
            this.helpAboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpAboutToolStripMenuItem.Image")));
            this.helpAboutToolStripMenuItem.Name = "helpAboutToolStripMenuItem";
            this.helpAboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpAboutToolStripMenuItem.Text = "About";
            this.helpAboutToolStripMenuItem.Click += new System.EventHandler(this.helpAboutToolStripMenuItem_Click);
            // 
            // mianStatusStrip
            // 
            this.mianStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainStatusToolStripStatusLabel});
            this.mianStatusStrip.Location = new System.Drawing.Point(0, 461);
            this.mianStatusStrip.Name = "mianStatusStrip";
            this.mianStatusStrip.Size = new System.Drawing.Size(711, 22);
            this.mianStatusStrip.TabIndex = 6;
            // 
            // mainStatusToolStripStatusLabel
            // 
            this.mainStatusToolStripStatusLabel.Name = "mainStatusToolStripStatusLabel";
            this.mainStatusToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.composeToolStripButton,
            this.checkMailToolStripButton});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(711, 25);
            this.mainToolStrip.TabIndex = 1;
            // 
            // composeToolStripButton
            // 
            this.composeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.composeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("composeToolStripButton.Image")));
            this.composeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.composeToolStripButton.Name = "composeToolStripButton";
            this.composeToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.composeToolStripButton.Text = "Compose Mail";
            this.composeToolStripButton.Click += new System.EventHandler(this.composeToolStripButton_Click);
            // 
            // checkMailToolStripButton
            // 
            this.checkMailToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.checkMailToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("checkMailToolStripButton.Image")));
            this.checkMailToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.checkMailToolStripButton.Name = "checkMailToolStripButton";
            this.checkMailToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.checkMailToolStripButton.Text = "Check Mail";
            this.checkMailToolStripButton.Click += new System.EventHandler(this.checkMailToolStripButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.AccessibleDescription = "";
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(669, 53);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(30, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Location = new System.Drawing.Point(565, 55);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mail Id:";
            // 
            // MainForm
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.mianStatusStrip);
            this.Controls.Add(this.mailListView);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mianStatusStrip.ResumeLayout(false);
            this.mianStatusStrip.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView mailListView;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailComposeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailCheckMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpAboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip mianStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel mainStatusToolStripStatusLabel;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton composeToolStripButton;
        private System.Windows.Forms.ToolStripButton checkMailToolStripButton;
        private System.Windows.Forms.ColumnHeader subjectColumnHeader1;
        private System.Windows.Forms.ColumnHeader messageColumnHeader;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
    }
}

