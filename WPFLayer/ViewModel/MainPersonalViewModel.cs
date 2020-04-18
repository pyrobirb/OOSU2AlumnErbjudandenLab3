using BusinessEntites.Models;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WPFLayer.Models;
using WPFLayer.Models.Junctions;
using WPFLayer.View;

namespace WPFLayer.ViewModel
{


    public class MainPersonalViewModel : INotifyPropertyChanged
    {
        private readonly DelegateCommand _SkapaAktivitetMeddelandeCommand;
        public ICommand SkapaAktivitetMeddelandeCommand => _SkapaAktivitetMeddelandeCommand;

        private readonly DelegateCommand _RedigeraAktivitetCommand;
        public ICommand RedigeraAktivitetCommand => _RedigeraAktivitetCommand;

        private readonly DelegateCommand _VäljAlumnTillInformationsutskickCommand;
        public ICommand VäljAlumnTillInformationsutskickCommand => _VäljAlumnTillInformationsutskickCommand;

        private readonly DelegateCommand _FlyttaRedigeraAlumnerCommand;
        public ICommand FlyttaRedigeraAlumnerCommand => _FlyttaRedigeraAlumnerCommand;

        private readonly DelegateCommand _PubliceraUtskickCommand;
        public ICommand PubliceraUtskickCommand => _PubliceraUtskickCommand;

        private readonly DelegateCommand _LoggaUtCommand;
        public ICommand LoggaUtCommand => _LoggaUtCommand;

        private readonly DelegateCommand _VäljAlumnTillMaillista_ClickCommand;
        public ICommand VäljAlumnTillMaillista_ClickCommand => _VäljAlumnTillMaillista_ClickCommand;


        private readonly DelegateCommand _TaBortAlumnFrånMaillista_ClickCommand;
        public ICommand TaBortAlumnFrånMaillista_ClickCommand => _TaBortAlumnFrånMaillista_ClickCommand;

        private readonly DelegateCommand _SkapaMaillistaOchCSVfil_ClickCommand;
        public ICommand SkapaMaillistaOchCSVfil_ClickCommand => _SkapaMaillistaOchCSVfil_ClickCommand;



        public MainPersonalViewModel()
        {
            _SkapaAktivitetMeddelandeCommand = new DelegateCommand(SkapaAktivitetMeddelande);
            _RedigeraAktivitetCommand = new DelegateCommand(RedigeraAktivitet);
            _VäljAlumnTillInformationsutskickCommand = new DelegateCommand(VäljAlumnTillInformationsutskick);
            _FlyttaRedigeraAlumnerCommand = new DelegateCommand(FlyttaRedigeraAlumner);
            _PubliceraUtskickCommand = new DelegateCommand(PubliceraUtskick);
            _LoggaUtCommand = new DelegateCommand(LoggaUt);
            _VäljAlumnTillMaillista_ClickCommand = new DelegateCommand(VäljAlumnTillMaillista_Click);
            _TaBortAlumnFrånMaillista_ClickCommand = new DelegateCommand(TaBortAlumnFrånMaillista_Click);
            _SkapaMaillistaOchCSVfil_ClickCommand = new DelegateCommand(SkapaMaillistaOchCSVfil_Click);

            UppdateraProgram();
            UppdateraAktiviteter();
            DatePickerDagensDatum();
            UppdateraGamlaUtskick();
        }

        private void LoggaUt(object commandParameter)
        {
            GLOBALSWPF.AktuellPersonal = null;

            foreach (var window in Application.Current.Windows)
            {
                if (window is MainPersonalWindow x)
                {
                    x.Close();
                }
            }

            var anvNamn = HelperClass.FindChild<TextBox>(Application.Current.MainWindow, "InloggAnvändarnamn");
            anvNamn.Text = "";

            var pwdBox = HelperClass.FindChild<PasswordBox>(Application.Current.MainWindow, "Lösenord");
            pwdBox.Clear();

            Application.Current.MainWindow.Show();

        }

        private void UppdateraGamlaUtskick()
        {
            GamlaUtskickMaillista = Maillista.HämtaAllaMaillistor();
        }

        private void DatePickerDagensDatum()
        {
            Aktivitet.Startdatum = DateTime.Today;
            Aktivitet.Slutdatum = DateTime.Today;
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
            set
            {
                alumner = value;
                Changed();
            }
        }

        private Aktivitet valdAktivitet;

        public Aktivitet ValdAktivitet
        {
            get { return valdAktivitet; }
            set
            {
                valdAktivitet = value;
                Changed();

            }
        }


        private ObservableCollection<Program> programs;
        public ObservableCollection<Program> Programs
        {
            get { return programs; }
            set
            {
                programs = value;
                Changed();
            }
        }

        public void UppdateraProgram()
        {
            Programs = Program.HämtaAllaProgram();
        }


        #region Aktivitet
        private Aktivitet aktivitet = new Aktivitet();
        public Aktivitet Aktivitet
        {
            get { return aktivitet; }
            set
            {
                aktivitet = value;
                Changed();
            }
        }

        private Aktivitet aktivitetAnmälda = new Aktivitet();
        public Aktivitet AktivitetAnmälda
        {
            get { return aktivitetAnmälda; }
            set
            {
                aktivitetAnmälda = value;
                Changed();
                SeAnmälningarValdAktivitet_SelectionChanged();
            }
        }

        private Program mailProgram = new Program();
        public Program MailProgram
        {
            get { return mailProgram; }
            set
            {
                mailProgram = value;
                Changed();
                ProgramComboBox_SelectionChanged_2();
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


        internal bool SkapaAktiviteten(Aktivitet aktivitet)
        {
            UppdateraAktiviteter();
            return Aktivitet.Spara(aktivitet);

        }

        internal void FiltreraProgramAlumner(Program selectedItem)
        {
            Alumner = Program.HämtaProgramAlumner(selectedItem);
        }


        public bool SkapaAktivitet()
        {
            if (SkapaAktiviteten(Aktivitet))
            {
                NollaAktivitet();
                UppdateraAktiviteter();
                return true;
            }
            else return false;

        }

        private void NollaAktivitet()
        {
            Aktivitet.Titel = null;
            Aktivitet.Kontaktperson = null;
            Aktivitet.Ansvarig = null;
            Aktivitet.Plats = null;
            Aktivitet.Startdatum = DateTime.Today;
            Aktivitet.Slutdatum = DateTime.Today;
            Aktivitet.Beskrivning = null;
        }

        public void UppdateraAktiviteter()
        {
            Aktiviteter = Aktivitet.HämtaAktiviteter();
        }

        public void RedigeraAktiviteten(int aktivitetsid, string titel, string kontaktperson, string ansvarig, string plats, DateTime startdatum, DateTime slutdatum, string beskrivning)
        {
            Aktivitet.Redigera(aktivitetsid, titel, kontaktperson, ansvarig, plats, startdatum, slutdatum, beskrivning);
        }




        #endregion

        public void SkapaAktivitetMeddelande(object commandParameter)
        {

            if (SkapaAktivitet())
            {
                MessageBox.Show("Aktiviteten har skapats!");
            }
            else
            {
                MessageBox.Show("Något gick fel, vänligen försök igen! Se till att alla rutor är ifyllda.");
            }
        }


        public void RedigeraAktivitet(object commandParameter)
        {

            int selectedAktivitetID = ValdAktivitet.AktivitetsID;
            string titel = ValdAktivitet.Titel;
            string kontaktperson = ValdAktivitet.Kontaktperson;
            string ansvarig = ValdAktivitet.Ansvarig;
            string plats = ValdAktivitet.Plats;
            DateTime startdatum = ValdAktivitet.Startdatum;
            DateTime slutdatum = ValdAktivitet.Slutdatum;
            string beskrivning = ValdAktivitet.Beskrivning;


            RedigeraAktiviteten(selectedAktivitetID, titel, kontaktperson, ansvarig, plats, startdatum, slutdatum, beskrivning);
            MessageBox.Show("Ändringarna har sparats!");
        }

        public void VäljAlumnTillInformationsutskick(object commandParameter)
        {
            ListBox foundListBox =
            HelperClass.FindChild<ListBox>(Application.Current.Windows.OfType<MainPersonalWindow>().FirstOrDefault(), "FlyttaRedigeraAlumner");

            List<Alumn> temp = new List<Alumn>();

            foreach (Alumn item in foundListBox.SelectedItems)
            {
                temp.Add(item);
            }
            LäggTillAlumnerIRedigeraLista(temp);
        }

        private void FlyttaRedigeraAlumner(object commandParameter)
        {
            ListBox foundListBox =
            HelperClass.FindChild<ListBox>(Application.Current.Windows.OfType<MainPersonalWindow>().FirstOrDefault(), "PubliceraAktivitetValdaAlumner");


            List<Alumn> valdaAlumnerAttTabort = new List<Alumn>();
            foreach (Alumn alumn in foundListBox.SelectedItems)
            {
                valdaAlumnerAttTabort.Add(alumn);
            }
            TaBortValdaAlumnerFrånRedigeraLista(valdaAlumnerAttTabort);

        }

        private void PubliceraUtskick(object commandParameter)
        {
            ComboBox foundComboBox =
            HelperClass.FindChild<ComboBox>(Application.Current.Windows.OfType<MainPersonalWindow>().FirstOrDefault(), "VäljAktivitetComboBox");

            PubliceraAktivitetTillAlumner((Aktivitet)foundComboBox.SelectedItem);

                MessageBox.Show("Utskick skapat");


            UtvaldaRedigeraAlumner.Clear();
        }

        private void SeAnmälningarValdAktivitet_SelectionChanged()
        {

            ComboBox AnmälningarValdAktivitet =
            HelperClass.FindChild<ComboBox>(Application.Current.Windows.OfType<MainPersonalWindow>().FirstOrDefault(), "SeAnmälningarValdAktivitet");

            DataGrid DataGridAnmäldaAlumner =
            HelperClass.FindChild<DataGrid>(Application.Current.Windows.OfType<MainPersonalWindow>().FirstOrDefault(), "valdAktivitetDataGridMedAlumner");

            UppdateraSeAnmälningarValdAktivitetSeAlumner(AktivitetAnmälda);

            DataGridAnmäldaAlumner.Columns[0].Visibility = Visibility.Hidden;
            DataGridAnmäldaAlumner.Columns[1].Visibility = Visibility.Hidden;
            DataGridAnmäldaAlumner.Columns[2].Visibility = Visibility.Hidden;
            DataGridAnmäldaAlumner.Columns[3].Visibility = Visibility.Hidden;
            DataGridAnmäldaAlumner.Columns[4].Visibility = Visibility.Hidden;
            DataGridAnmäldaAlumner.Columns[5].Visibility = Visibility.Visible;
            DataGridAnmäldaAlumner.Columns[6].Visibility = Visibility.Visible;
            DataGridAnmäldaAlumner.Columns[7].Visibility = Visibility.Hidden;
            DataGridAnmäldaAlumner.Columns[8].Visibility = Visibility.Visible;
            DataGridAnmäldaAlumner.Columns[9].Visibility = Visibility.Visible;


        }

        

        private void ProgramComboBox_SelectionChanged_2()
        {
            ComboBox MaillistaProgram =
                HelperClass.FindChild<ComboBox>(Application.Current.Windows.OfType<MainPersonalWindow>().FirstOrDefault(), "SkapaMaillistaFiltreraPåProgramComboBox");

            FiltreraProgramAlumner((Program)MailProgram);
        }


        private void VäljAlumnTillMaillista_Click(object commandParameter)
        {
            ListBox AlumnTillMail =
                HelperClass.FindChild<ListBox>(Application.Current.Windows.OfType<MainPersonalWindow>().FirstOrDefault(), "AlumnerAttFlyttaTillSkapaMaillista");

            List<Alumn> temp = new List<Alumn>();
            foreach (Alumn item in AlumnTillMail.SelectedItems)
            {
                temp.Add(item);
            }
            LäggTillAlumnerILista(temp);
        }

        private void TaBortAlumnFrånMaillista_Click(object commandParameter)
        {
            ListBox AlumnTillMail =
                HelperClass.FindChild<ListBox>(Application.Current.Windows.OfType<MainPersonalWindow>().FirstOrDefault(), "skapaMaillistaValdaAlumnerListBox");

            List<Alumn> valdaAlumnerAttTabort = new List<Alumn>();
            foreach (Alumn alumn in AlumnTillMail.SelectedItems)
            {
                valdaAlumnerAttTabort.Add(alumn);
            }
            TabortValdaAlumnerFrånUtvaldaAlumner(valdaAlumnerAttTabort);
        }


        private void SkapaMaillistaOchCSVfil_Click(object commandParameter)
        {
            TextBox namngivning =
                HelperClass.FindChild<TextBox>(Application.Current.Windows.OfType<MainPersonalWindow>().FirstOrDefault(), "namngeMaillistaTextBox");

            ListBox skapaMaillista =
                HelperClass.FindChild<ListBox>(Application.Current.Windows.OfType<MainPersonalWindow>().FirstOrDefault(), "skapaMaillistaValdaAlumnerListBox");

            if (namngivning.Text == "")
            {
                MessageBox.Show("Du måste namnge listan.");
            }
            else if (skapaMaillista.Items.Count < 1)
            {
                MessageBox.Show("Du måste lägga till minst en alumn i listan valda alumner.");
            }
            else
            {
                SkapaMaillista(namngivning.Text);
                MessageBox.Show("Maillistan har skapats!\n\n" + "Maillistans namn och Alumnernas epostadresser har blivit skrivna till CSV Filen!" +
                                 "Filen hittar du OOSU2AlumnErbjudanden/OOSU2AlumnErbjudanden/PresentationLayer/bin/Debug/");
            }
            TömMailLista();
            namngivning.Clear();
        }

        private ObservableCollection<Alumn> utvaldaAlumner = new ObservableCollection<Alumn>();
        public ObservableCollection<Alumn> UtvaldaALumner
        {
            get { return utvaldaAlumner; }
            set
            {
                utvaldaAlumner = value;
                Changed();
            }
        }

        private ObservableCollection<Alumn> utvaldaRedigeraAlumner = new ObservableCollection<Alumn>();
        public ObservableCollection<Alumn> UtvaldaRedigeraAlumner
        {
            get { return utvaldaRedigeraAlumner; }
            set
            {
                utvaldaRedigeraAlumner = value;
                Changed();
            }
        }
        private ObservableCollection<Alumn> utvaldaRedigeraAlumnerMaillista = new ObservableCollection<Alumn>();
        public ObservableCollection<Alumn> UtvaldaRedigeraAlumnerMaillista
        {
            get { return utvaldaRedigeraAlumner; }
            set
            {
                utvaldaRedigeraAlumner = value;
                Changed();
            }
        }

        private ObservableCollection<Alumn> valdAktivitetListaDataGridMedAlumner = new ObservableCollection<Alumn>();
        public ObservableCollection<Alumn> ValdAktivitetListaDataGridMedAlumner
        {
            get { return utvaldaRedigeraAlumner; }
            set
            {
                utvaldaRedigeraAlumner = value;
                Changed();
            }
        }

        private ObservableCollection<Maillista> gamlaUtskickMaillista = new ObservableCollection<Maillista>();
        public ObservableCollection<Maillista> GamlaUtskickMaillista
        {
            get { return gamlaUtskickMaillista; }
            set
            {
                gamlaUtskickMaillista = value;
                Changed();
            }
        }

        internal void PubliceraAktivitetTillAlumner(Aktivitet selectedItem)
        {
            Aktivitet.PubliceraAktivitetTillAlumner(selectedItem, UtvaldaRedigeraAlumner);
        }

        public void TaBortValdaAlumnerFrånRedigeraLista(List<Alumn> alumnerAttTaBort)
        {

            var nyLista = UtvaldaRedigeraAlumner.Except(alumnerAttTaBort);

            ObservableCollection<Alumn> utvaldaNyLista = new ObservableCollection<Alumn>();
            foreach (Alumn alumn in nyLista)
            {
                utvaldaNyLista.Add(alumn);
            }

            UtvaldaRedigeraAlumner = utvaldaNyLista;

        }

        internal void SkapaMaillista(string namnMaillista)
        {
            BusinessManager bm = new BusinessManager();
            var mapper = MapperConfig.GetMapper();
            Maillista.SkapaMailLista(namnMaillista);
            AlumnMaillista.SkapaAlumnMaillista(UtvaldaRedigeraAlumnerMaillista);

            List<AlumnDTO> nyLista = new List<AlumnDTO>();
            foreach (Alumn item in UtvaldaRedigeraAlumnerMaillista)
            {
                nyLista.Add(mapper.Map<Alumn, AlumnDTO>(item));
            }

            bm.SkrivaAlumnAktivitetTillCSVFil(namnMaillista, nyLista);
            UppdateraGamlaUtskick();

        }

        internal void TömMailLista()
        {
            UtvaldaRedigeraAlumnerMaillista = new ObservableCollection<Alumn>();

        }

        public void UppdateraSeAnmälningarValdAktivitetSeAlumner(Aktivitet selectedItem)
        {
            Console.WriteLine("poopo");
            ValdAktivitetListaDataGridMedAlumner = Alumn.HämtaAnmälningarGenomAktivitetsID(selectedItem.AktivitetsID);
        }

        internal void ImporteraAlumnerFrånGammalMaillista(Maillista maillista)
        {
            //från selecteditems alumner 
            



            //till UtvaldaRedigeraAlumnerMaillista  
            LäggTillAlumnerILista(Maillista.HämtaAlumnerFrånMaillista(maillista));
        }

        internal void LäggTillAlumnerIRedigeraLista(List<Alumn> temp)
        {
            foreach (var item in temp)
            {
                bool AddAlumn = true;
                foreach (Alumn alumn in UtvaldaRedigeraAlumner)
                {
                    if (alumn.AnvändarID == item.AnvändarID)
                    {
                        AddAlumn = false;
                    }
                }
                if (AddAlumn)
                {
                    UtvaldaRedigeraAlumner.Add(item);
                }

            }
        }

        internal void LäggTillAlumnerILista(List<Alumn> temp)
        {
            foreach (var item in temp)
            {
                bool AddAlumn = true;
                foreach (Alumn alumn in UtvaldaRedigeraAlumnerMaillista)
                {
                    if (alumn.AnvändarID == item.AnvändarID)
                    {
                        AddAlumn = false;
                    }
                }
                if (AddAlumn)
                {
                    UtvaldaRedigeraAlumnerMaillista.Add(item);
                }

            }
        }

        internal void TabortValdaAlumnerFrånUtvaldaAlumner(List<Alumn> valdaAlumnerAttTabort)
        {
            var nyLista = UtvaldaRedigeraAlumner.Except(valdaAlumnerAttTabort);

            ObservableCollection<Alumn> utvaldaNyLista = new ObservableCollection<Alumn>();
            foreach (Alumn alumn in nyLista)
            {
                utvaldaNyLista.Add(alumn);
            }

            UtvaldaRedigeraAlumnerMaillista = utvaldaNyLista;
        }
    }
}
