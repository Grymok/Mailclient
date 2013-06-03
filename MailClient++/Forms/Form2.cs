using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace MailClient__
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Sendmailbutton_Click(object sender, EventArgs e)
        {
           try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient(MailClient__.Properties.Settings.Default.smtpserver);

                    mail.From = new MailAddress(MailClient__.Properties.Settings.Default.Username);
                    mail.To.Add(mailtotextBox.Text);
                    mail.Subject = subjecttextbox.Text;
                    mail.Body = topicrichTextBox.Text;

                    SmtpServer.Port = MailClient__.Properties.Settings.Default.smtpport;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(MailClient__.Properties.Settings.Default.Username, MailClient__.Properties.Settings.Default.userpassword);
                    SmtpServer.EnableSsl = MailClient__.Properties.Settings.Default.EnableSSL;

                    SmtpServer.Send(mail);
                    MessageBox.Show("mail Send");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

           
        }
        

        private void canclebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsbutton_Click(object sender, EventArgs e)
        {
            MailClient__.Forms.Form3 f3 = new MailClient__.Forms.Form3();
            f3.ShowDialog(); // Shows Form2
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
