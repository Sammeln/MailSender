using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.GUI.Services
{
    /// <summary>
    /// Сервис данных
    /// </summary>
    public interface IDataService
    {
        /// <summary>
        /// Получить коллекцию персоналий
        /// </summary>
        /// <returns></returns>
        ObservableCollection<Persone> GetPersones();

        /// <summary>
        /// Сохранить персоналию в сервисе данных
        /// </summary>
        /// <param name="persone">Сохраняемая персоналия</param>
        /// <returns>Индекс сохранённой персоналии</returns>
        int SavePersone(Persone persone);
    }

    /// <summary>
    /// Сервис данных, основанный на базе данных
    /// </summary>
    class DataBaseService : IDataService
    {
        /// <summary>
        /// Контекст базы данных
        /// </summary>
        private readonly MailSenderDBDataContext _Context = new MailSenderDBDataContext();

        public ObservableCollection<Persone> GetPersones()
        {
            return new ObservableCollection<Persone>(_Context.Persone);
        }

        public int SavePersone(Persone persone)
        {
            _Context.Persone.InsertOnSubmit(persone);
            _Context.SubmitChanges();
            return persone.PersonesId;
        }
    }

    /// <summary>
    /// Сервис данных, построенный на фале
    /// </summary>
    class FileDataBaseService : IDataService
    {
        public ObservableCollection<Persone> GetPersones() => throw new NotImplementedException();

        public int SavePersone(Persone persone) => throw new NotImplementedException();

    }
}
