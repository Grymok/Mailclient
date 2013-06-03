namespace MailClient__
{
    partial class Form2
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
            this.sendmailbutton = new System.Windows.Forms.Button();
            this.canclebutton = new System.Windows.Forms.Button();
            this.settingsbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subjecttextbox = new System.Windows.Forms.TextBox();
            this.mailtotextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.topicrichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // sendmailbutton
            // 
            this.sendmailbutton.Location = new System.Drawing.Point(13, 340);
            this.sendmailbutton.Name = "sendmailbutton";
            this.sendmailbutton.Size = new System.Drawing.Size(84, 23);
            this.sendmailbutton.TabIndex = 0;
            this.sendmailbutton.Text = "Send Mail";
            this.sendmailbutton.UseVisualStyleBackColor = true;
            this.sendmailbutton.Click += new System.EventHandler(this.Sendmailbutton_Click);
            // 
            // canclebutton
            // 
            this.canclebutton.Location = new System.Drawing.Point(120, 340);
            this.canclebutton.Name = "canclebutton";
            this.canclebutton.Size = new System.Drawing.Size(75, 23);
            this.canclebutton.TabIndex = 1;
            this.canclebutton.Text = "Cancle";
            this.canclebutton.UseVisualStyleBackColor = true;
            this.canclebutton.Click += new System.EventHandler(this.canclebutton_Click);
            // 
            // settingsbutton
            // 
            this.settingsbutton.Location = new System.Drawing.Point(496, 340);
            this.settingsbutton.Name = "settingsbutton";
            this.settingsbutton.Size = new System.Drawing.Size(75, 23);
            this.settingsbutton.TabIndex = 2;
            this.settingsbutton.Text = "Settings";
            this.settingsbutton.UseVisualStyleBackColor = true;
            this.settingsbutton.Click += new System.EventHandler(this.settingsbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mail to:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subject:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // subjecttextbox
            // 
            this.subjecttextbox.Location = new System.Drawing.Point(12, 79);
            this.subjecttextbox.Name = "subjecttextbox";
            this.subjecttextbox.Size = new System.Drawing.Size(235, 22);
            this.subjecttextbox.TabIndex = 5;
            // 
            // mailtotextBox
            // 
            this.mailtotextBox.Location = new System.Drawing.Point(13, 34);
            this.mailtotextBox.Name = "mailtotextBox";
            this.mailtotextBox.Size = new System.Drawing.Size(234, 22);
            this.mailtotextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Topic";
            // 
            // topicrichTextBox
            // 
            this.topicrichTextBox.Location = new System.Drawing.Point(12, 148);
            this.topicrichTextBox.Name = "topicrichTextBox";
            this.topicrichTextBox.Size = new System.Drawing.Size(559, 186);
            this.topicrichTextBox.TabIndex = 8;
            this.topicrichTextBox.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 375);
            this.Controls.Add(this.topicrichTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mailtotextBox);
            this.Controls.Add(this.subjecttextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settingsbutton);
            this.Controls.Add(this.canclebutton);
            this.Controls.Add(this.sendmailbutton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendmailbutton;
        private System.Windows.Forms.Button canclebutton;
        private System.Windows.Forms.Button settingsbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subjecttextbox;
        private System.Windows.Forms.TextBox mailtotextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox topicrichTextBox;
    }
}