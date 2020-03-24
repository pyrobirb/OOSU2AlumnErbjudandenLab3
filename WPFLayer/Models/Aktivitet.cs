using BusinessEntites.Models;
using BusinessEntites.Models.Junction;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WPFLayer.Models
{
    [DataContract]
    public class Aktivitet : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [DataMember]
        private int aktivitetsID;
        [DataMember]
        private string titel;
        [DataMember]
        private string kontaktperson;
        [DataMember]
        private string ansvarig;
        [DataMember]
        private string plats;
        [DataMember]
        private DateTime startdatum;
        [DataMember]
        private DateTime slutdatum;
        [DataMember]
        private string beskrivning;
        [DataMember]
        public virtual ICollection<InformationsutskickAktivitetDTO> InformationsutskickAktivitet { get; set; }
        [DataMember]
        public virtual ICollection<AlumnAktivitetBokningDTO> AlumnAktivitet { get; set; }

        public int AktivitetsID
        {
            get { return aktivitetsID; }
            set { aktivitetsID = value; }
        }

        public string Titel
        {
            get { return titel; }
            set
            {
                titel = value;
                Changed();
            }
        }
        public string Kontaktperson
        {
            get { return kontaktperson; }
            set
            {
                kontaktperson = value;
                Changed();
            }
        }
        public string Ansvarig
        {
            get { return ansvarig; }
            set
            {
                ansvarig = value;
                Changed();
            }
        }
        public string Plats
        {
            get { return plats; }
            set
            {
                plats = value;
                Changed();
            }
        }
        public DateTime Startdatum
        {
            get { return startdatum; }
            set
            {
                startdatum = value;
                Changed();
            }
        }
        public DateTime Slutdatum
        {
            get { return slutdatum; }
            set
            {
                slutdatum = value;
                Changed();
            }
        }
        public string Beskrivning
        {
            get { return beskrivning; }
            set
            {
                beskrivning = value;
                Changed();
            }
        }

        

        public static ObservableCollection<Aktivitet> HämtaAktiviteter()
        {
            BusinessManager bm = new BusinessManager();
            var mapper = MapperConfig.GetMapper();
            ObservableCollection<Aktivitet> x = new ObservableCollection<Aktivitet>();

            foreach (var item in bm.HämtaAllaAktiviteter())
            {
                x.Add(mapper.Map<AktivitetDTO, Aktivitet>(item));
            }
            return x;
        }

        public static ObservableCollection<Aktivitet> HämtaAktiviteterFörInloggadAnvändare()
        {
            BusinessManager bm = new BusinessManager();
            var mapper = MapperConfig.GetMapper();
            ObservableCollection<Aktivitet> y = new ObservableCollection<Aktivitet>();

            foreach (var item in bm.HämtaAktiviteterGenomInformationsutskickID(bm.HämtaInformationsutskickAlumnGenomAlumnID(GLOBALSWPF.AktuellAlumn)))
            {
                y.Add(mapper.Map<AktivitetDTO, Aktivitet>(item));
            }
            return y;
        }

        public void Spara()
        {
            BusinessManager bm = new BusinessManager();
            var mapper = MapperConfig.GetMapper();

            Aktivitet aktivitet = new Aktivitet()
            {
                Titel = this.Titel,
                Kontaktperson = this.Kontaktperson,
                Ansvarig = this.Ansvarig,
                Plats = this.Plats,
                Startdatum = this.Startdatum,
                Slutdatum = this.Slutdatum,
                Beskrivning = this.Beskrivning
            };

            bm.LäggTillAktivitet(mapper.Map<Aktivitet, AktivitetDTO>(aktivitet));
        }
    }
}
