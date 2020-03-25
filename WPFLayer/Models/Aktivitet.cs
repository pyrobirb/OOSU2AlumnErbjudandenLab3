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
using System.Windows;
using WPFLayer.Models.Junctions;
using WPFLayer.Models.Interfaces;

namespace WPFLayer.Models
{
    [DataContract]
    public class Aktivitet : INotifyPropertyChanged, IAktivitet
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



        internal static ObservableCollection<Aktivitet> HämtaBokadeAktiviteter()
        {
            BusinessManager bm = new BusinessManager();
            var mapper = MapperConfig.GetMapper();
            ObservableCollection<Aktivitet> HämtadeAktiviteter = new ObservableCollection<Aktivitet>();

            var HA = bm.HämtaAktiviteterGenomAktivitetID(bm.HämtaAktiviteterGenomAlumn(GLOBALSWPF.AktuellAlumn));
            foreach (var item in HA)
            {
                HämtadeAktiviteter.Add(mapper.Map<AktivitetDTO, Aktivitet>(item));
            }

            return HämtadeAktiviteter;
        }

        internal void PubliceraAktivitetTillAlumner(Aktivitet selectedItem, ObservableCollection<Alumn> utvaldaRedigeraAlumner)
        {
            BusinessManager bm = new BusinessManager();
            var mapper = MapperConfig.GetMapper();

            Informationsutskick informationsutskick = new Informationsutskick()
            {
                UtskicksID = 0,
                UtskicksNamn = null,
                UtskickDatum = DateTime.Now,
            };
            bm.LäggTillInformationsutskick(mapper.Map<Informationsutskick, InformationsutskickDTO>(informationsutskick));

            InformationsutskickAktivitet informationsutskickAktivitet = new InformationsutskickAktivitet()
            {
                AktivitetID = selectedItem.AktivitetsID,
                InformationsutskickID = informationsutskick.UtskicksID
            };
            bm.LäggTillInformationsutskickAktivitet(mapper.Map<InformationsutskickAktivitet, InformationsutskickAktivitetDTO>(informationsutskickAktivitet));

            foreach (Alumn alumn in utvaldaRedigeraAlumner)
            {
                InformationsutskickAlumn informationsutskickAlumn = new InformationsutskickAlumn()
                {
                    AlumnID = alumn.AnvändarID,
                    InformationsutskickID = informationsutskick.UtskicksID
                };
                bm.LäggTillInformationsutskickAlumn(mapper.Map<InformationsutskickAlumn, InformationsutskickAlumnDTO>(informationsutskickAlumn));
            }
            bm.Commit();
        }

        public bool Spara(Aktivitet aktivitet)
        {
            BusinessManager bm = new BusinessManager();
            var mapper = MapperConfig.GetMapper();

            if ((aktivitet.Titel == null || aktivitet.Titel == "" || aktivitet.Kontaktperson == null || aktivitet.Kontaktperson == "" || aktivitet.Ansvarig == null || aktivitet.Ansvarig == "" || aktivitet.plats == null || aktivitet.plats == "" || aktivitet.beskrivning == null || aktivitet.beskrivning == ""))
            {
                return false;
            }

            else
            {
                Aktivitet NyAktivitet = new Aktivitet()
                {
                    Titel = this.Titel,
                    Kontaktperson = this.Kontaktperson,
                    Ansvarig = this.Ansvarig,
                    Plats = this.Plats,
                    Startdatum = this.Startdatum,
                    Slutdatum = this.Slutdatum,
                    Beskrivning = this.Beskrivning
                };

                bm.LäggTillAktivitet(mapper.Map<Aktivitet, AktivitetDTO>(NyAktivitet));


                return true;
            }
        }



        public void Redigera(int aktivitetsid, string titel, string kontaktperson, string ansvarig, string plats, DateTime startdatum, DateTime slutdatum, string beskrivning)
        {
            BusinessManager bm = new BusinessManager();
            var mapper = MapperConfig.GetMapper();

            Aktivitet NyAktivitet = new Aktivitet()
            {
                Titel = titel,
                Kontaktperson = kontaktperson,
                Ansvarig = ansvarig,
                Plats = plats,
                Startdatum = startdatum,
                Slutdatum = slutdatum,
                Beskrivning = beskrivning
            };

            var GammalAktivitet = mapper.Map<AktivitetDTO, Aktivitet>(bm.HämtaAktivitetGenomID(aktivitetsid));
            bm.UpdateAktivitetWPF(mapper.Map<Aktivitet, AktivitetDTO>(GammalAktivitet), mapper.Map<Aktivitet, AktivitetDTO>(NyAktivitet));
        }

        internal static void Avboka(object selectedItem)
        {
            BusinessManager bm = new BusinessManager();
            var mapper = MapperConfig.GetMapper();

            Aktivitet aktivitet = (Aktivitet)selectedItem;
            if (aktivitet != null)
            {
                bm.TaBortAktivitetFrånAlumn(mapper.Map<Aktivitet, AktivitetDTO>(aktivitet), GLOBALSWPF.AktuellAlumn);

                MessageBox.Show("Bokningen har raderats");
            }
            else
            {
                MessageBox.Show("Du måste välja vilken aktivitet du vill avboka.");
            }


        }

        internal static void HämtaBokadeAktiviteter(object selectedItem)
        {
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
        }
    }
}
