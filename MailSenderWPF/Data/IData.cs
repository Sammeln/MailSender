using MailSenderWPF.Entity.Implementation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSenderWPF.Data
{
    public interface IData
    {
         ObservableCollection<SenderModel> Senders { get; set; }
         ObservableCollection<RecipientModel> Recipients { get; set; }
         ObservableCollection<MailMessageModel> Messages { get; set; }
         ObservableCollection<SMTPModel> SMTPList { get; set; }
    }
}
