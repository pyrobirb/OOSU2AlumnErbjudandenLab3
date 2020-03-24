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
            UppdateraProgram();
            UppdateraAktiviteter();
            DatePickerDagensDatum();
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
            //fortsätt
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

        public bool SkapaAktivitet()
        {
            if (SkapaAktiviteten(Aktivitet))
            {
                NollaAktivitet();
                return true;
            }
            else return false;
            //Update();
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

    }
}
