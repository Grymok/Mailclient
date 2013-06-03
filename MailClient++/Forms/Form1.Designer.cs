namespace MailClient__
{
    partial class Form1
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstSubjectHeaders = new System.Windows.Forms.ListBox();
            this.rtxtMessageBody = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.progBarMailFetch = new System.Windows.Forms.ProgressBar();
            this.lblMessageCount = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.moreOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendMailToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(12, 40);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 22);
            this.txtUsername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(130, 40);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // lstSubjectHeaders
            // 
            this.lstSubjectHeaders.FormattingEnabled = true;
            this.lstSubjectHeaders.IntegralHeight = false;
            this.lstSubjectHeaders.ItemHeight = 16;
            this.lstSubjectHeaders.Location = new System.Drawing.Point(12, 74);
            this.lstSubjectHeaders.Name = "lstSubjectHeaders";
            this.lstSubjectHeaders.Size = new System.Drawing.Size(249, 356);
            this.lstSubjectHeaders.TabIndex = 4;
            this.lstSubjectHeaders.Tag = "";
            this.lstSubjectHeaders.SelectedIndexChanged += new System.EventHandler(this.lstSubjectHeaders_SelectedIndexChanged);
            // 
            // rtxtMessageBody
            // 
            this.rtxtMessageBody.Location = new System.Drawing.Point(268, 74);
            this.rtxtMessageBody.Name = "rtxtMessageBody";
            this.rtxtMessageBody.Size = new System.Drawing.Size(350, 354);
            this.rtxtMessageBody.TabIndex = 5;
            this.rtxtMessageBody.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Fetch mail";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progBarMailFetch
            // 
            this.progBarMailFetch.Location = new System.Drawing.Point(12, 441);
            this.progBarMailFetch.Name = "progBarMailFetch";
            this.progBarMailFetch.Size = new System.Drawing.Size(605, 13);
            this.progBarMailFetch.TabIndex = 7;
            // 
            // lblMessageCount
            // 
            this.lblMessageCount.AutoSize = true;
            this.lblMessageCount.Location = new System.Drawing.Point(469, 43);
            this.lblMessageCount.Name = "lblMessageCount";
            this.lblMessageCount.Size = new System.Drawing.Size(130, 17);
            this.lblMessageCount.TabIndex = 8;
            this.lblMessageCount.Text = "Message Count = 0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moreOptionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(520, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(110, 467);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // moreOptionToolStripMenuItem
            // 
            this.moreOptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendMailToToolStripMenuItem});
            this.moreOptionToolStripMenuItem.Name = "moreOptionToolStripMenuItem";
            this.moreOptionToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.moreOptionToolStripMenuItem.Text = "More option";
            // 
            // sendMailToToolStripMenuItem
            // 
            this.sendMailToToolStripMenuItem.Name = "sendMailToToolStripMenuItem";
            this.sendMailToToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.sendMailToToolStripMenuItem.Text = "Send mail to";
            this.sendMailToToolStripMenuItem.Click += new System.EventHandler(this.sendMailToToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 467);
            this.Controls.Add(this.lblMessageCount);
            this.Controls.Add(this.progBarMailFetch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtxtMessageBody);
            this.Controls.Add(this.lstSubjectHeaders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstSubjectHeaders;
        private System.Windows.Forms.RichTextBox rtxtMessageBody;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progBarMailFetch;
        private System.Windows.Forms.Label lblMessageCount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moreOptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendMailToToolStripMenuItem;
    }
}

