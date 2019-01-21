using MailSenderWPF.Entity.Interface;
using MailSenderWPF.Service;

namespace MailSenderWPF.Entity.Implementation
{
    public class SenderModel : ViewModelBase, ISenderEntity
    {
        private int id;
        private string name;
        private string password;
        private string eMail;
        private SMTPModel sMTP;

        public int Id
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string Password
        {
            get => password;
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public string EMail
        {
            get => eMail;
            set
            {
                eMail = value;
                OnPropertyChanged(nameof(EMail));
            }
        }
        public SMTPModel SMTP
        {
            get => sMTP;
            set
            {
                sMTP = value;
                OnPropertyChanged(nameof(SMTP));
            }
        }



    }
}
