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
using BusinessEntites.Models.Junction;
using System.Collections.Specialized;
using WPFLayer.Models.Junctions;
using BusinessEntites.Models;
using System.Windows.Input;

namespace WPFLayer.ViewModel
{
    public class MainAlumnViewModel : INotifyPropertyChanged, INotifyCollectionChanged
    {

        // Skapa ICommands...
        private readonly DelegateCommand _SparaÄndradeAnvändaruppgifterCommand;
        public ICommand SparaÄndradeAnvändaruppgifterCommand => _SparaÄndradeAnvändaruppgifterCommand;

        public MainAlumnViewModel()
        {
            _SparaÄndradeAnvändaruppgifterCommand = new DelegateCommand(SparaÄndradeAnvändaruppgifter);
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


        private ObservableCollection<Program> aktuellaProgram = new ObservableCollection<Program>();



        public ObservableCollection<Program> AktuellaProgram
        {
            get { return aktuellaProgram; }
            set
            {
                aktuellaProgram = value;
                Changed();
            }
        }

        private ObservableCollection<Kompetens> aktuellaKompetenser = new ObservableCollection<Kompetens>();
        public ObservableCollection<Kompetens> AktuellaKompetenser
        {
            get { return aktuellaKompetenser; }
            set
            {
                aktuellaKompetenser = value;
                Changed();
            }
        }



        internal void BokaValdAktivitet(object selectedItem)
        {
            Aktivitet.HämtaBokadeAktiviteter(selectedItem);           
            Update();
        }

        public void Update()
        {
            Alumner = Alumn.HämtaAlumner();
            Aktiviteter = Aktivitet.HämtaAktiviteter();
            InloggadAlumn = Alumn.HämtaInloggadAlumn();
            AktuellaAktiviteter = Aktivitet.HämtaAktiviteterFörInloggadAnvändare();
            BokadeAktiviteter = Aktivitet.HämtaBokadeAktiviteter();
            AktuellaProgram = Program.HämtaAlumnensProgram();
            AktuellaKompetenser = Kompetens.HämtaAlumnensKompetenser();
        }



        public void SparaÄndradeAnvändaruppgifter(object commandParameter)
        {
            Alumn.SparaÄndradeUppgifter(inloggadAlumn.Förnamn, inloggadAlumn.Efternamn, inloggadAlumn.Användarnamn, inloggadAlumn.Lösenord);
            Update();
        }

        internal void TaBortAlumnKonto()
        {
            Alumn.TaBort();
        }

        internal void AvbokaValdAktivitet(object selectedItem)
        {
            Aktivitet.Avboka(selectedItem);
            Update();

        }

        internal void LäggtillUtbildning(string text)
        {
            Program.LäggTill(text);
            Update();
        }

        internal void LäggTillKompetens(string text)
        {
            Kompetens.LäggTill(text);
            Update();
        }

        internal void TaBortProgram(object selectedItem)
        {
            Program.Tabort(selectedItem);
            Update();
        }

        internal void TaBortKompetens(object selectedItem)
        {
            Kompetens.TaBort(selectedItem);
            Update();
        }


    }
}
