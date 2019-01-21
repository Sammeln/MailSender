using MailSenderWPF.Entity.Interface;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MailSenderWPF.Service;

namespace MailSenderWPF.Entity.Implementation
{
    public class RecipientModel : ViewModelBase, IBaseEntity, INamedEntity, IEmailAddress
    {
        #region Private members

        private int id;
        private string name;
        private string email;

        #endregion
        #region Public props

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
        public string EMail { get; set; } 
        #endregion
    }
}
