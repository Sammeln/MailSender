using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace MailSender
{
    public class MailService
    {
        public static void SendMail
        (
            string UserName, SecureString Password,
            string From, string To,
            string Subject, string Body
        )
        {
            using (var message = new MailMessage(From, To) { Subject = Subject, Body = Body })
            using (var client = new SmtpClient("smtp.yandex.ru" /*, 25*/)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(UserName, Password)
            })
                client.Send(message);
        }
    }
}
