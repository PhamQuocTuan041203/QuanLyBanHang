using System;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace BUS
{
    public class BUS_Mail
    {
        private string senderEmail;
        private string senderPassword;

        public BUS_Mail(string senderEmail, string senderPassword)
        {
            this.senderEmail = senderEmail;
            this.senderPassword = senderPassword;
        }

        public string SendMail(string recipientEmail, string recipientPassword, bool isUpdate = false)
        {
            try
            {
                MailMessage mailMsg = new MailMessage();
                mailMsg.From = new MailAddress(senderEmail);
                mailMsg.To.Add(recipientEmail);

                if (isUpdate)
                {
                    mailMsg.Subject = "Cấp lại mật khẩu phần mềm!";
                    mailMsg.Body = "Chào bạn, mật khẩu mới truy cập vào phần mềm của bạn là: " + recipientPassword;
                }
                else
                {
                    mailMsg.Subject = "Thông tin đăng nhập phần mềm!";
                    mailMsg.Body = string.Format("Chào mừng bạn đã trở thành nhân viên của Công ty QuocTuanFashion, thông tin đăng nhập là:" +
                        "\n- Email: {0} \n- Mật khẩu: {1} ", recipientEmail, recipientPassword);
                }

                using (SmtpClient client = new SmtpClient())
                {
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(senderEmail, senderPassword);
                    client.Host = "smtp.gmail.com";
                    client.Port = 587;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.Send(mailMsg);
                }
                return "Kiểm tra Email để nhận mật khẩu!";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string GetRandomPassword()
        {
            Random r = new Random();
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(3));
            builder.Append(r.Next(100, 999));
            return builder.ToString();
        }

        private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            Random r = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * r.NextDouble() + 97)));
                builder.Append(ch);
            }
            return builder.ToString();
        }
    }
}
