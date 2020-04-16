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
using System.Windows.Input;
using WPFLayer.Models;
using WPFLayer.Models.Junctions;

namespace WPFLayer.ViewModel
{


    public class MainPersonalViewModel : INotifyPropertyChanged
    {
        private readonly DelegateCommand _SkapaAktivitetMeddelandeCommand;
        public ICommand SkapaAktivitetMeddelandeCommand => _SkapaAktivitetMeddelandeCommand;

        public MainPersonalViewModel()
        {
            _SkapaAktivitetMeddelandeCommand = new DelegateCommand(SkapaAktivitetMeddelande);
            UppdateraProgram();
            UppdateraAktiviteter();
            DatePickerDagensDatum();
            UppdateraGamlaUtskick();
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
            ValdAktivitetListaDataGridMedAlumner = Alumn.HämtaAnmälningarGenomAktivitetsID(selectedItem.AktivitetsID);
        }

        internal void ImporteraAlumnerFrånGammalMaillista(Maillista maillista)
        {
            //från selecteditems alumner 
            ;



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
