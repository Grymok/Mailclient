using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenPop.Mime;
using OpenPop.Mime.Decode;
using OpenPop.Mime.Header;
using OpenPop.Common.Logging;
using OpenPop.Pop3;
using System.Data.SQLite;



namespace MailClient__
{
    public partial class Form1 : Form
    {
        List<OpenPop.Mime.Message> list;


        private BackgroundWorker worker;

        string username, password;
        int messageCount;

        SQLiteConnection connection;

        public Form1()
        {
            InitializeComponent();


            list = new List<OpenPop.Mime.Message>();

            worker = new BackgroundWorker();

            worker.WorkerReportsProgress = true;

            worker.DoWork += new DoWorkEventHandler(fetchAllMessages);
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);

            string connectionString = @"data source='messages.db'";
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            string sqlCreateTable = "CREATE TABLE IF NOT EXISTS [messages]";
            sqlCreateTable += "([id] TEXT NOT NULL PRIMARY KEY,";
            sqlCreateTable += "[sender] TEXT NULL,[subject] TEXT NULL, [body] TEXT NULL);";
            SQLiteCommand cmdCreateTable = new SQLiteCommand(sqlCreateTable, connection);
            cmdCreateTable.ExecuteNonQuery();

            connection.Close();
        }




        private void fetchAllMessages(object sender, DoWorkEventArgs e)
        {
            int percentComplete;

            // The client disconnects from the server when being disposed
            using (Pop3Client client = new Pop3Client())
            {
                // Connect to the server
                //client.Connect("pop.gmail.com", 995, true);
                //Taking the data from usersettings.settings
                client.Connect(MailClient__.Properties.Settings.Default.openpopserver, MailClient__.Properties.Settings.Default.popport, MailClient__.Properties.Settings.Default.EnableSSL);



                // Authenticate ourselves towards the server
                client.Authenticate(username, password);

                // Get the number of messages in the inbox
                messageCount = client.GetMessageCount();

                // We want to download all messages
                List<OpenPop.Mime.Message> allMessages = new List<OpenPop.Mime.Message>(messageCount);


                // Messages are numbered in the interval: [1, messageCount]
                // Ergo: message numbers are 1-based.
                // Most servers give the latest message the highest number

                for (int i = messageCount; i > 0; i--)
                {
                    allMessages.Add(client.GetMessage(i));
                    percentComplete = Convert.ToInt16((Convert.ToDouble(allMessages.Count) / Convert.ToDouble(messageCount)) * 100);
                    (sender as BackgroundWorker).ReportProgress(percentComplete);
                }

                // Now return the fetched messages
                e.Result = allMessages;



                SQLiteCommand commandInsert = new SQLiteCommand("INSERT OR IGNORE INTO messages (id, sender, subject, body) VALUES (@id, @sender, @subject, @body)", connection);
                connection.Open();

                foreach (OpenPop.Mime.Message message in allMessages)
                {
                    if (message.Headers.MessageId != null)
                    {
                        commandInsert.Parameters.AddWithValue("@id", message.Headers.MessageId);
                        commandInsert.Parameters.AddWithValue("@sender", message.Headers.From.Address);
                        commandInsert.Parameters.AddWithValue("@subject", message.Headers.Subject);
                        if (!message.MessagePart.IsMultiPart)
                        {
                            commandInsert.Parameters.AddWithValue("@body", message.MessagePart.GetBodyAsText());
                        }
                        else
                        {
                            OpenPop.Mime.MessagePart plainText = message.FindFirstPlainTextVersion();
                            commandInsert.Parameters.AddWithValue("@body", plainText.GetBodyAsText());
                        }

                        int result = commandInsert.ExecuteNonQuery();
                    }
                }

                commandInsert.Dispose();
                connection.Close();
            }
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progBarMailFetch.Value = e.ProgressPercentage;
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            list = (List<OpenPop.Mime.Message>)e.Result;

            lblMessageCount.Text = "Message Count = " + messageCount;

            lstSubjectHeaders.Items.Clear();
            foreach (OpenPop.Mime.Message message in list)
            {
                lstSubjectHeaders.Items.Add(message.Headers.Subject.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;
            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync();
            }
        }

        private void lstSubjectHeaders_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedItem = lstSubjectHeaders.SelectedIndex;
            if (list[selectedItem].MessagePart.IsMultiPart)
            {
                OpenPop.Mime.MessagePart plainText = list[selectedItem].FindFirstPlainTextVersion();
                rtxtMessageBody.Text = plainText.GetBodyAsText();
            }
            else
            {
                rtxtMessageBody.Text = list[selectedItem].MessagePart.GetBodyAsText();
            }
        }

        private void sendMailToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog(); // Shows Form2
        }

        //This ain't working yet, but i'm trying to get it to work.
        public void updatDB()
        {
            lstSubjectHeaders.Items.Clear();
            try
            {


                /*
                string connectionString = @"data source='messages.db'";
                connection = new SQLiteConnection(connectionString);
                connection.Open();
                string sqlCreateTable = "CREATE TABLE IF NOT EXISTS [messages]";
                sqlCreateTable += "([id] TEXT NOT NULL PRIMARY KEY,";
                sqlCreateTable += "[sender] TEXT NULL,[subject] TEXT NULL, [body] TEXT NULL);";
                SQLiteCommand cmdCreateTable = new SQLiteCommand(sqlCreateTable, connection);
                cmdCreateTable.ExecuteNonQuery();

                connection.Close();
                */


                SQLiteConnection sqliteCon = new SQLiteConnection(@"Data Source = messages.db;");

                connection.Open();
                List<Msg> dbmsg = new List<Msg>();
                SQLiteCommand cmdRead = new SQLiteCommand("SELECT * FROM Messages ", sqliteCon);
                SQLiteDataReader reader = cmdRead.ExecuteReader();
                //Reading from the Database
                //
                while (reader.Read())
                {
                    string msgID = reader.GetString(0);
                    string msgSender = reader.GetString(1);
                    string msgSubject = reader.GetString(2);
                    string msgBody = reader.GetString(3);
                    dbmsg.Add(new Msg { MsgID = msgID, MsgSender = msgSender, MsgSubject = msgSubject, MsgBody = msgBody });
                }



                foreach (Msg msg in dbmsg)
                {
                    ADD_NEW_DATA data = new ADD_NEW_DATA(msg.MsgSubject, msg.MsgID, "Data3");
                    lstSubjectHeaders.Items.Add(data);
                    //Subjectname.Items.Add(msg.MsgSubject);

                    // sercetBox.Items.Add(msg.MsgID);
                }
                sqliteCon.Close();

            }
        }
    }
}

