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
using System.Windows;

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

        private Alumn inloggadAlumn = new Alumn();
        public Alumn InloggadAlumn
        {
            get { return inloggadAlumn; }
            set
            {
                inloggadAlumn = value;
                Changed();
            }
        }

        public void Update()
        {
            Alumner = Alumn.HämtaAlumner();
            Aktiviteter = Aktivitet.HämtaAktiviteter();
            InloggadAlumn = Alumn.HämtaInloggadAlumn();
        }

        internal void SparaÄndradeAnvändaruppgifter(string ändraFörnamn, string ändraEfternamn, string ändraEpostadress, string ändraLösenord)
        {
            BusinessManager bm = new BusinessManager();

            if (RegexUtilities.IsValidEmail(ändraEpostadress) == true)
            {
                var InloggadAlumn = bm.HämtaAlumnMedID(GLOBALSWPF.AktuellAlumn.AnvändarID);
                var gammaltFörnamn = InloggadAlumn.Förnamn;
                var gammaltEfternamn = InloggadAlumn.Efternamn;
                var gammalepostadress = InloggadAlumn.Användarnamn;
                bm.UppdateraAlumn(InloggadAlumn.AnvändarID, ändraFörnamn, ändraEfternamn, ändraEpostadress);
                GLOBALSWPF.AktuellAlumn = bm.HämtaAlumnMedID(InloggadAlumn.AnvändarID);
                MessageBox.Show($"Dina uppgifter är nu uppdaterade: " +
                    $"\n{gammaltFörnamn} -> {GLOBALSWPF.AktuellAlumn.Förnamn} " +
                    $"\n{gammaltEfternamn} -> {GLOBALSWPF.AktuellAlumn.Efternamn} " +
                    $"\n{gammalepostadress} -> {GLOBALSWPF.AktuellAlumn.Användarnamn}");
            }
            else
            {
                MessageBox.Show("Var vänlig fyll i en giltig mailadress");
            }

        }

    }
}
