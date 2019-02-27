using MailSenderWPF.Data;
using MailSenderWPF.Entity.Implementation;
using MailSenderWPF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSenderWPF.ViewModel
{
    public class AddEditSenderVM : ViewModelBase
    {
        #region fields

        private SenderModel currentSender;
        IData context;
        private RelayCommand confirmCommand;
        private RelayCommand cancelCommand;

        #endregion
        public RelayCommand ConfirmCommand
        {
            get
            {
                return confirmCommand ?? (confirmCommand = new RelayCommand(obj =>
                {
                    if (true)
                    {
                        context.AddSender(currentSender);
                    }
                }));
            }
        }

        #region Props

        public SenderModel CurrentSender
        {
            get => currentSender;
            set
            {
                currentSender = value;
                OnPropertyChanged(nameof(CurrentSender));
            }
        }
        #endregion

        #region CTOR

        public AddEditSenderVM(IData data, SenderModel sender)
        {
            context = data;
            CurrentSender = sender;
        }
        public AddEditSenderVM(IData data)
        {
            context = data;
            currentSender = new SenderModel();
        } 
        #endregion

    }
}
