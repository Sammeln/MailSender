using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MailSenderWPF.Entity.Interface;
using MailSenderWPF.Service;

namespace MailSenderWPF.Entity.Implementation
{
    public class SMTPModel : ViewModelBase, INamedEntity, IBaseEntity
    {
        #region private members

        private int id;
        private string name;
        private string domain;
        private int port;

        #endregion

        #region public props

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
        public string Domain
        {
            get => domain;
            set
            {
                domain = value;
                OnPropertyChanged(nameof(Domain));
            }
        }
        public int Port
        {
            get => port;
            set
            {
                port = value;
                OnPropertyChanged(nameof(Port));
            }
        }

        #endregion

    }
}
