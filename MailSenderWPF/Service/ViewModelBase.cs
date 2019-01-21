using System.Runtime.CompilerServices;
using System.ComponentModel;
using MailSenderWPF.Data;

namespace MailSenderWPF.Service
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
