using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;

namespace WebSite11
{ 
    /// <summary>
    /// Сводное описание для HtmlObjects
    /// </summary>
    public class SendMail
    {
        private string mailText;
        private string user;
        private const string passMail = "PavDem01";
        private string subject = "";
        
        public SendMail(string user, string phone, string message)
        {
            mailText = message;
            this.user = user;
            subject = phone;
        }

        public void MySendMail()
        {
            MailAddress from = new MailAddress("lmd05@mail.ru", user);
            MailAddress to = new MailAddress("fred_risp@mail.ru", "name");

            //try
            //{
                SmtpClient smtp = new SmtpClient("smtp.mail.ru", 25);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from.Address, passMail);
                smtp.EnableSsl = true;
                smtp.Timeout = 20000;

                MailMessage mail = new MailMessage(from, to);
                mail.Subject = subject;
                mail.Body = mailText;
                smtp.Send(mail);
            //}
            //catch (Exception ex)
            //{
            //}
        }
    }
}