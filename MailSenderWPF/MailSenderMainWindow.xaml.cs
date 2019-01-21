using System.Windows;
using MailSenderWPF.ViewModel;
using MailSenderWPF.Data;

namespace MailSenderWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MailSenderMainWindow : Window
    {
        public MailSenderMainWindow()
        {
            InitializeComponent();
            DataContext = new SenderViewModel(new InMemoryData());
        }
    }
}
