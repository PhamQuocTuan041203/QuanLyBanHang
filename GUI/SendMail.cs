using BUS;
using System;
using System.Threading;
using System.Windows.Forms;

namespace GUI
{
    public partial class SendMail : Form
    {
        private string result;
        private string email;
        private string password;
        private bool isUpdate;

        public string Result { get => result; set => result = value; }

        public SendMail(string email, string pass, bool isUpdate = false)
        {
            InitializeComponent();
            this.email = email;
            this.password = pass;
            this.isUpdate = isUpdate;
        }

        private void SendMail_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(Send);
            thread.IsBackground = true;
            thread.Start();
        }

        private void Send()
        {
            string loginEmail = "thotrangpro2@gmail.com";
            string loginPassword = "jane tslj naeb isei";

            BUS_Mail mail = new BUS_Mail(loginEmail, loginPassword);

            Result = mail.SendMail(email, password, isUpdate);
            pcbLoader.Invoke(new Action(() => Close()));
        }
    }
}
