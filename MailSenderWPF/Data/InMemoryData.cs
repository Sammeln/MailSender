using System.Collections.ObjectModel;
using MailSenderWPF.Entity.Implementation;

namespace MailSenderWPF.Data
{
    public class InMemoryData : Service.ViewModelBase, IData
    {
        #region fields

        private static InMemoryData instance;
        private ObservableCollection<SenderModel> senders;

        #endregion

        #region props
        public ObservableCollection<SenderModel> Senders
        {
            get => senders;
            set
            {
                senders = value;
                OnPropertyChanged(nameof(Senders));
            }
        }
        public ObservableCollection<RecipientModel> Recipients { get; set; }
        public ObservableCollection<MailMessageModel> Messages { get; set; }
        public ObservableCollection<SMTPModel> SMTPList { get; set; }
        #endregion

        #region CTOR

        public InMemoryData()
        {
            Senders = new ObservableCollection<SenderModel>
            {
                new SenderModel
                {
                    Id = 1,
                    Name = "Кирилл",
                    EMail = "nosyrkov@mail.ru",
                    Password = "Mail460608600913",
                    SMTP = new SMTPModel
                    {
                        Id = 1,
                        Domain = "smtp.mail.ru",
                        Port = 465,
                        Name = "Mail.ru"
                    }
                },
                new SenderModel
                {
                    Id = 2,
                    Name = "Кирилл",
                    EMail = "kn@agrovent.ru",
                    Password = "Agrovent2724509",
                    SMTP = new SMTPModel
                    {
                        Id = 2,
                        Domain = "smtp.yandex.ru",
                        Port = 465,
                        Name = "Yandex"
                    }
                }
            };
        }

        #endregion

        #region Singleton

        public static InMemoryData GetInstance()
        {
            return instance ?? new InMemoryData();
        }

        #endregion

        #region Methods

        public void AddSender(SenderModel sender)
        {
            if (sender != null)
            {
                senders.Add(sender);
            }
        }

        #endregion
    }
}
