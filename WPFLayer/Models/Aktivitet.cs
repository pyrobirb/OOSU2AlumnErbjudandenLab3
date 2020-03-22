using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WPFLayer.Models
{
    [DataContract]
    public class Aktivitet
    {
        [DataMember]
        public int AktivitetsID { get; set; }
        [DataMember]
        public string Titel { get; set; }
        [DataMember]
        public string Kontaktperson { get; set; }
        [DataMember]
        public string Ansvarig { get; set; }
        [DataMember]
        public string Plats { get; set; }
        [DataMember]
        public DateTime Startdatum { get; set; }
        [DataMember]
        public DateTime Slutdatum { get; set; }
        [DataMember]
        public string Beskrivning { get; set; }
        [DataMember]
        public virtual ICollection<InformationsutskickAktivitetDTO> InformationsutskickAktivitet { get; set; }
        [DataMember]
        public virtual ICollection<AlumnAktivitetBokningDTO> AlumnAktivitet { get; set; }

        internal static ObservableCollection<Aktivitet> HämtaAktiviteter()
        {
            throw new NotImplementedException();
        }
    }
}
