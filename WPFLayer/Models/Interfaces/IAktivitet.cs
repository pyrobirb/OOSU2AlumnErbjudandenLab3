using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFLayer.Models.Interfaces
{
    public interface IAktivitet
    {
        event PropertyChangedEventHandler PropertyChanged;
        void Changed([CallerMemberName] String propertyName = "");
       
        ICollection<InformationsutskickAktivitetDTO> InformationsutskickAktivitet { get; set; }
        ICollection<AlumnAktivitetBokningDTO> AlumnAktivitet { get; set; }

        int AktivitetsID { get; set; }
        string Titel { get; set; }
        string Kontaktperson { get; set; }
        string Ansvarig { get; set; }
        string Plats { get; set; }
        DateTime Startdatum { get; set; }
        DateTime Slutdatum { get; set; }
        string Beskrivning { get; set; }
        bool Spara(Aktivitet aktivitet);
        void Redigera(int aktivitetsid, string titel, string kontaktperson, string ansvarig, string plats, DateTime startdatum, DateTime slutdatum, string beskrivning);
       
    }
}
