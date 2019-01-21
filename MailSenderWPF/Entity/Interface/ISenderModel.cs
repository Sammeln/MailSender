using MailSenderWPF.Entity.Implementation;

namespace MailSenderWPF.Entity.Interface
{
    public interface ISenderModel
    {
        string EMail { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        string Password { get; set; }
        SMTPModel SMTP { get; set; }
    }
}