using MailSenderWPF.Entity.Implementation;
using MailKit.Net.Smtp;
using MimeKit;

namespace MailSenderWPF.Service
{
    public class MailSendService
    {
        private MimeMessage mailMessage;
        private SenderModel sender;
        private RecipientModel recipient;

        public MailSendService(MailMessageModel message, SenderModel sender, RecipientModel recipient)
        {
            this.sender = sender;
            this.recipient = recipient;

            mailMessage = new MimeMessage();
            mailMessage.From.Add(new MailboxAddress(sender.Name,sender.EMail));
            mailMessage.To.Add(new MailboxAddress(recipient.EMail));
            mailMessage.Subject = message.Subject;
            mailMessage.Body = new TextPart
            {
                Text = message.Body
            };

        }
        public void Send()
        {
            using (SmtpClient client = new SmtpClient())
            {
                client.Connect(sender.SMTP?.Domain,sender.SMTP.Port);
                client.Authenticate(sender.EMail, sender.Password);

                client.Send(mailMessage);

                client.Disconnect(true);
            }
        }
    }
}
