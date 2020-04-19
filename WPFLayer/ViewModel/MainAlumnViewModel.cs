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
using WPFLayer.View;
using System.Windows.Controls;

namespace WPFLayer.ViewModel
{
    public class MainAlumnViewModel : INotifyPropertyChanged, INotifyCollectionChanged
    {

        // Skapa ICommands
        private readonly DelegateCommand _SparaÄndradeAnvändaruppgifterCommand;
        public ICommand SparaÄndradeAnvändaruppgifterCommand => _SparaÄndradeAnvändaruppgifterCommand;

        private readonly DelegateCommand _TaBortAlumnKontoCommand;
        public ICommand TaBortAlumnKontoCommand => _TaBortAlumnKontoCommand;

        private readonly DelegateCommand _BokaValdAktivitetCommand;
        public ICommand BokaValdAktivitetCommand => _BokaValdAktivitetCommand;

        private readonly DelegateCommand _AvbokaValdAktivitetCommand;
        public ICommand AvbokaValdAktivitetCommand => _AvbokaValdAktivitetCommand;

        private readonly DelegateCommand _LäggtillUtbildningCommand;
        public ICommand LäggtillUtbildningCommand => _LäggtillUtbildningCommand;

        private readonly DelegateCommand _LäggTillKompetensCommand;
        public ICommand LäggTillKompetensCommand => _LäggTillKompetensCommand;

        private readonly DelegateCommand _TaBortProgramCommand;
        public ICommand TaBortProgramCommand => _TaBortProgramCommand;

        private readonly DelegateCommand _TaBortKompetensCommand;
        public ICommand TaBortKompetensCommand => _TaBortKompetensCommand;

        private readonly DelegateCommand _LoggaUtCommand;
        public ICommand LoggaUtCommand => _LoggaUtCommand;


        public MainAlumnViewModel()
        {
            Update();
            //Instantiera propertieserna
            _SparaÄndradeAnvändaruppgifterCommand = new DelegateCommand(SparaÄndradeAnvändaruppgifter);
            _TaBortAlumnKontoCommand = new DelegateCommand(TaBortAlumnKonto);
            _BokaValdAktivitetCommand = new DelegateCommand(BokaValdAktivitet);
            _AvbokaValdAktivitetCommand = new DelegateCommand(AvbokaValdAktivitet);
            _LäggtillUtbildningCommand = new DelegateCommand(LäggtillUtbildning);
            _LäggTillKompetensCommand = new DelegateCommand(LäggTillKompetens);
            _TaBortProgramCommand = new DelegateCommand(TaBortProgram);
            _TaBortKompetensCommand = new DelegateCommand(TaBortKompetens);
            _LoggaUtCommand = new DelegateCommand(LoggaUt);

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
            set
            {
                alumner = value;
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

        private Aktivitet selectedAktivitet;

        public Aktivitet SelectedAktivitet
        {
            get { return selectedAktivitet; }
            set
            {
                selectedAktivitet = value;
                Changed();
            }
        }


        private string textBoxTextUtbildning;

        public string TextBoxTextUtbildning
        {
            get { return textBoxTextUtbildning; }
            set
            {
                textBoxTextUtbildning = value;
                Changed();
            }
        }

        private string textBoxTextKompetens;

        public string TextBoxTextKompetens
        {
            get { return textBoxTextKompetens; }
            set
            {
                textBoxTextKompetens = value;
                Changed();
            }
        }

        private Program selectedProgram;

        public Program Selectedprogram
        {
            get { return selectedProgram; }
            set
            {
                selectedProgram = value;
                Changed();
            }
        }

        private Kompetens selectedKompetens;

        public Kompetens SelectedKompetens
        {
            get { return selectedKompetens; }
            set
            {
                selectedKompetens = value;
                Changed();
            }
        }


        private void LoggaUt(object commandParameter)
        {
            GLOBALSWPF.AktuellAlumn = null;



            foreach (var window in Application.Current.Windows)
            {
                if (window is MainAlumnWindow x)
                {
                    x.Close();
                }
            }

            Application.Current.MainWindow.Show();

            var anvNamn = HelperClass.FindChild<TextBox>(Application.Current.MainWindow, "InloggAnvändarnamn");
            anvNamn.Text = "";

            var pwdBox = HelperClass.FindChild<PasswordBox>(Application.Current.MainWindow, "Lösenord");
            pwdBox.Clear();

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


        internal void BokaValdAktivitet(object commandParameter) //Klar
        {
            Aktivitet.HämtaBokadeAktiviteter(SelectedAktivitet);
            Update();
        }

        public void SparaÄndradeAnvändaruppgifter(object commandParameter) //Klar
        {
            Alumn.SparaÄndradeUppgifter(inloggadAlumn.Förnamn, inloggadAlumn.Efternamn, inloggadAlumn.Användarnamn, inloggadAlumn.Lösenord);
            Update();
        }

        public void TaBortAlumnKonto(object commandParameter) //Klar
        {
            Alumn.TaBort();
            GLOBALSWPF.AktuellAlumn = null;
            MainWindow loginWindow = new MainWindow();
            foreach (var window in Application.Current.Windows)
            {
                if (window is MainAlumnWindow x)
                {
                    x.Close();
                }
            }
            loginWindow.Show();
        }

        internal void AvbokaValdAktivitet(object commandParameter) //Klar
        {
            Aktivitet.Avboka(SelectedAktivitet);
            Update();

        }

        internal void LäggtillUtbildning(object commandParameter) //Klar
        {
            Program.LäggTill(TextBoxTextUtbildning);
            TextBoxTextUtbildning = string.Empty;
            Update();
        }

        internal void LäggTillKompetens(object commandParameter) //Klar
        {
            Kompetens.LäggTill(TextBoxTextKompetens);
            TextBoxTextKompetens = string.Empty;
            Update();
        }

        internal void TaBortProgram(object commandParameter) //Klar
        {

            if (Selectedprogram != null)
            {
                Program.Tabort(Selectedprogram);
                Update();
            }
        }

        internal void TaBortKompetens(object commandParameter)
        {

            if (SelectedKompetens != null)
            {

                Kompetens.TaBort(SelectedKompetens);
                Update();
            }
        }


    }
}
