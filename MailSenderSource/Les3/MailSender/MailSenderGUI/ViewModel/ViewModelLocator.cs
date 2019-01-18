/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:MailSender.GUI"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using MailSender.GUI.Services;

namespace MailSender.GUI.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {   
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<IDataService, DataBaseService>();  // –егистрируем интерфейс сервиса данных в соответствии с классом сервиса базы данных
            SimpleIoc.Default.Register<SenderWindowViewModel>();   // –егистрируем класс модели представлени€ рассыльщика почты

        }

        /// <summary>
        /// главна€ модель представлени€ - у нас никак не задействована - вообще можно удалить - приведена разработчиками как пример
        /// </summary>
        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();


        /// <summary>
        /// ћодель представлени€ рассыльщика почты
        /// </summary>
        public SenderWindowViewModel SenderModel => ServiceLocator.Current.GetInstance<SenderWindowViewModel>();

        /// <summary>ћетод, который будет вызван при закрытии приложени€ - здесь можно очистить какие-либо ресурсы</summary>
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}