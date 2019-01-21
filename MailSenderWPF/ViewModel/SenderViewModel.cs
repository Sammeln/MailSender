using MailSenderWPF.Entity.Implementation;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using MailSenderWPF.Service;
using MailSenderWPF.Data;

namespace MailSenderWPF.ViewModel
{
    public class SenderViewModel : ViewModelBase
    {
        #region private fields

        private SenderModel selectedSender;
        IData context;
        private RelayCommand addCommand;

        #endregion

        #region Commands

        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ?? (addCommand = new RelayCommand(obj =>
                {
                    SenderModel sender = new SenderModel
                    {
                        Id = SendersList.Count + 1,
                        Name = "_",
                        EMail = "_",
                        Password = "_",
                        SMTP = new SMTPModel()
                    };
                    context.Senders.Add(sender);
                }));
            }
        }

        #endregion

        #region props

        public ObservableCollection<SenderModel> SendersList { get; set; }
        public SenderModel SelectedSender
        {
            get => selectedSender;
            set
            {
                selectedSender = value;
                OnPropertyChanged(nameof(SelectedSender));
            }
        }

        #endregion

        #region CTOR
        public SenderViewModel(IData data)
        {
            context = data;
            SendersList = data.Senders;
        }
        #endregion
    }
}
