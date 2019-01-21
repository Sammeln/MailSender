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
        #region private members

        private SenderModel selectedSender;
        IData context;

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
