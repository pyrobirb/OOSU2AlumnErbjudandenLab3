using BusinessEntites.Models.Interfaces;
using BusinessEntites.Models.Junction;
//using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BusinessEntites.Models
{
    public class AktivaAktiviteter : ISubject, IAktivaAktiviteter
    {

        private List<IObserver> _observers = new List<IObserver>();

        private List<Aktivitet> _Aktiviteter = new List<Aktivitet>();


        public List<Aktivitet> Aktiviteter
        {
            get { return _Aktiviteter; }
            set { _Aktiviteter = value; }
        }

        public AktivaAktiviteter()
        {
            _observers = new List<IObserver>();
        }

        public List<Alumn> Alumner { get; set; }

        public void Add(IObserver observer)
        {
            if (observer != null)
            {
                _observers.Add(observer);
            }
        }

        public void Notify()
        {
            //behöver få tag på användar ID för de som är lagrade i _observers. 
            _observers.ForEach(o => o.UpdateNewMessage(ID, true));
        }

        public List<Aktivitet> HämtaAktiviteter()
        {
            return _Aktiviteter;
        }
    }
}
