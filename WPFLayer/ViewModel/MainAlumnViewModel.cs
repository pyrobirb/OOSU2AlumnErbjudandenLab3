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
using WPFLayer.Models.Junktions;
using BusinessEntites.Models.Junction;
using System.Collections.Specialized;

namespace WPFLayer.ViewModel
{
    public class MainAlumnViewModel : INotifyPropertyChanged, INotifyCollectionChanged
    {

        public MainAlumnViewModel()
        {
            Update();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            if (CollectionChanged != null)
            {
                CollectionChanged(this, e);
            }
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



        private ObservableCollection<Aktivitet> bokadeAktiviteter;

        public ObservableCollection<Aktivitet> BokadeAktiviteter
        {
            get { return bokadeAktiviteter; }
            set
            {
                bokadeAktiviteter = value;
                Changed();
            }
        }


        private ObservableCollection<Aktivitet> aktuellaAktiviteter = new ObservableCollection<Aktivitet>();
        public ObservableCollection<Aktivitet> AktuellaAktiviteter
        {
            get { return aktuellaAktiviteter; }
            set
            {
                aktuellaAktiviteter = value;
                Changed();
            }
        }

        internal void BokaValdAktivitet(object selectedItem)
        {
            //throw new NotImplementedException();
            BusinessManager bm = new BusinessManager();
            var mapper = MapperConfig.GetMapper();

            Aktivitet bokadAktivitet = (Aktivitet)selectedItem;

            AlumnAktivitetsBokning alumnAktivitetBokning = new AlumnAktivitetsBokning()
            {
                AlumnID = GLOBALSWPF.AktuellAlumn.AnvändarID,
                AktivitetID = bokadAktivitet.AktivitetsID,
            };

            bm.SparaBokadAktivitet(mapper.Map<AlumnAktivitetsBokning, AlumnAktivitetBokningDTO>(alumnAktivitetBokning));

            MessageBox.Show("Bokningen har skapats");
            Update();
        }

        public void Update()
        {
            Alumner = Alumn.HämtaAlumner();
            Aktiviteter = Aktivitet.HämtaAktiviteter();
            InloggadAlumn = Alumn.HämtaInloggadAlumn();
            AktuellaAktiviteter = Aktivitet.HämtaAktiviteterFörInloggadAnvändare();
            BokadeAktiviteter = Aktivitet.HämtaBokadeAktiviteter();
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
                bm.UppdateraAlumn(InloggadAlumn.AnvändarID, ändraFörnamn, ändraEfternamn, ändraEpostadress, ändraLösenord);
                GLOBALSWPF.AktuellAlumn = bm.HämtaAlumnMedID(InloggadAlumn.AnvändarID);
                MessageBox.Show($"Dina uppgifter är nu uppdaterade: " +
                    $"\n{gammaltFörnamn} -> {GLOBALSWPF.AktuellAlumn.Förnamn} " +
                    $"\n{gammaltEfternamn} -> {GLOBALSWPF.AktuellAlumn.Efternamn} " +
                    $"\n{gammalepostadress} -> {GLOBALSWPF.AktuellAlumn.Användarnamn}");
                Update();
            }
            else
            {
                MessageBox.Show("Var vänlig fyll i en giltig mailadress");
            }

        }

        internal void TaBortAlumnKonto()
        {
            BusinessManager bm = new BusinessManager();

            var alumnatttabort = bm.HämtaAlumnMedID((GLOBALSWPF.AktuellAlumn).AnvändarID);

            bm.TaBortAlumn(alumnatttabort);
            MessageBox.Show("Ditt konto är nu borttaget");
            bm.Commit();
        }

        internal void AvbokaValdAktivitet(object selectedItem)
        {
            throw new NotImplementedException();
        }
    }
}
