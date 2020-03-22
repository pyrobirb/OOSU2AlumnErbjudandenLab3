using System;
using BusinessLayer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using WPFLayer.Models;
using System.Collections.ObjectModel;

namespace WPFLayer.ViewModel
{
    public class MainAlumnViewModel : INotifyPropertyChanged
    {

        public MainAlumnViewModel()
        {
            Update();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private ObservableCollection<Alumn> alumner;
        public ObservableCollection<Alumn> Alumner
        {
            get { return alumner; }
            set { alumner = value;
                Changed();
            }
        }

        private ObservableCollection<Aktivitet> aktiviteter;
        public ObservableCollection<Aktivitet> Aktiviteter
        {
            get { return aktiviteter; }
            set { aktiviteter = value;
                Changed();
            }      
        }

        public void Update()
        {
            Alumner = Alumn.HämtaAlumner();
            Aktiviteter = Aktivitet.HämtaAktiviteter();
        }
    }
}
