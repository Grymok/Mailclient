using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailClient__.Forms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            MailClient__.Properties.Settings.Default.smtpserver = smtpservertextbox.Text;
            MailClient__.Properties.Settings.Default.smtpport = Convert.ToInt16(smtpporttextbox.Text);
            MailClient__.Properties.Settings.Default.Username = usernametextbox.Text;
            MailClient__.Properties.Settings.Default.userpassword = passwordtextbox.Text;
            MailClient__.Properties.Settings.Default.EnableSSL = sslcheckbox.Checked;


            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
