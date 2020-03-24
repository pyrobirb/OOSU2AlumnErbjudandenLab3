using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WPFLayer.Models;

namespace WPFLayer.ViewModel
{   


    public class CreateActivityViewModel : INotifyPropertyChanged
    {
        BusinessManager bm = new BusinessManager();

        public CreateActivityViewModel()
        {
            UppdateraAktiviteter();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private Aktivitet aktivitet = new Aktivitet();
        public Aktivitet Aktivitet
        {
            get { return aktivitet; }
            set { aktivitet = value;  
            Changed();
            }
        }




        private ObservableCollection<Aktivitet> aktiviteter;
        public ObservableCollection<Aktivitet> Aktiviteter
        {
            get { return aktiviteter; }
            set
            {
                aktiviteter = value;
                Changed();
            }
        }

        public void SkapaAktivitet()
        {
            Aktivitet.Spara();
            UppdateraAktiviteter();
        }

        public void UppdateraAktiviteter()
        {
            Aktiviteter = Aktivitet.HämtaAktiviteter();
        }

        
    }
}
