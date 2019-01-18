using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MailSender.GUI
{
    public partial class SenderWindow : Window
    {
        public SenderWindow()
        {
            InitializeComponent();
        }

        private void OnExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OnTabSwitcher_Forvard(object Sender, EventArgs E)
        {
            MailTabControl.SelectedIndex++;
        }

        private void OnTabSwitcher_Backward(object Sender, EventArgs E)
        {
            MailTabControl.SelectedIndex--;
        }
    }
}
