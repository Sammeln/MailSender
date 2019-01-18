using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MailSender.GUI.Services;

namespace MailSender.GUI.ViewModel
{
    /// <summary>
    /// Модель представления отправителя почты
    /// </summary>
    public class SenderWindowViewModel : ViewModelBase
    {
        /// <summary>
        /// Сервис данных
        /// </summary>
        private readonly IDataService _DataService;
        /// <summary>
        /// Персоналии
        /// </summary>
        private IEnumerable<Persone> _Persones;
        /// <summary>
        /// Текущая персоналия
        /// </summary>
        private Persone _CurrentPerson;

        /// <summary>
        /// Команда, закрывающая приложение
        /// </summary>
        public RelayCommand ApplicationCloseCommand { get; }
        /// <summary>
        /// Команда загрузки данных из базы
        /// </summary>
        public RelayCommand LoadPersonesCommand { get; }
        /// <summary>
        /// Создать новую персоналию
        /// </summary>
        public RelayCommand NewPersoneCommand { get; }
        /// <summary>
        /// Сохранить персоналию в базе
        /// </summary>
        public RelayCommand<Persone> SavePersoneCommand { get; }

        /// <summary>
        /// Персоналии
        /// </summary>
        public IEnumerable<Persone> Persones
        {
            get => _Persones;
            //set
            //{
            //    if(Equals(_Persones, value)) return;
            //    _Persones = value;
            //    //RaisePropertyChanged(() => Persones);
            //    //RaisePropertyChanged(nameof(Persones));
            //    RaisePropertyChanged();
            //}
            set => Set(ref _Persones, value);
        }

        /// <summary>
        /// Текущая персоналия
        /// </summary>
        public Persone CurrentPerson { get => _CurrentPerson; set => Set(ref _CurrentPerson, value); }

        /// <summary>
        /// Инициализация новой модели представления рассыльщика почты
        /// </summary>
        /// <param name="DataService">Сервис данных</param>
        public SenderWindowViewModel(IDataService DataService) // Сюда же надо внедрить сервис рассылки почты
        {
            _DataService = DataService;
            #region Создаём команды
            ApplicationCloseCommand = new RelayCommand(OnApplicationCloseCommandExecuted);
            LoadPersonesCommand = new RelayCommand(OnLoadPersonesExecuted);
            NewPersoneCommand = new RelayCommand(() => CurrentPerson = new Persone { PersonesId = _DataService.GetPersones().Max(p => p.PersonesId) + 1 });
            SavePersoneCommand = new RelayCommand<Persone>(OnSavePersoneCommandExecuted); 
            #endregion
        }

        private void OnSavePersoneCommandExecuted(Persone persone) => _DataService.SavePersone(persone);

        private void OnApplicationCloseCommandExecuted() => Application.Current.Shutdown();

        private void OnLoadPersonesExecuted() => Persones = _DataService.GetPersones();
    }
}
