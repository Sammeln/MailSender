using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using MailSenderControls;

namespace MailSender.GUI
{
    class SenderVindowViewModel : ViewModel
    {
        private string _TestString = "Data string";

        public string TestString
        {
            get => _TestString;
            set
            {
                if(_TestString == value) return;
                _TestString = value;
                OnPropertyChanged("TestString");
            }
        }

        private int _IntegerData = 42;

        public int IntegerData
        {
            get => _IntegerData;
            set
            {
                if(_IntegerData == value) return;
                _IntegerData = value;
                OnPropertyChanged(nameof(IntegerData));
            }
        }
    }
}
