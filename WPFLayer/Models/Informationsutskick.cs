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
using WPFLayer.Models.Interfaces;

namespace WPFLayer.Models
{
    [DataContract]
    public class Informationsutskick : INotifyPropertyChanged, IInformationsutskick
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

       

        [DataMember]
        private int utskicksID;
        [DataMember]
        private string utskicksNamn;
        [DataMember]
        private DateTime utskickDatum;
        [DataMember]
        public virtual ICollection<Alumn> Alumner { get; set; }
        [DataMember]
        public virtual ICollection<InformationsutskickAlumnDTO> InformationsutskickAlumn { get; set; }
        [DataMember]
        public virtual ICollection<PersonalInformationsutskickDTO> PersonalInformationsutskick { get; set; }
        [DataMember]
        public virtual ICollection<InformationsutskickAktivitetDTO> InformationsutskickAktivitet { get; set; }



        public int UtskicksID
        {
            get { return utskicksID; }
            set { utskicksID = value; }
        }

        public string UtskicksNamn
        {
            get { return utskicksNamn; }
            set
            {
                utskicksNamn = value;
                Changed();
            }
        }

        public DateTime UtskickDatum
        {
            get { return utskickDatum; }
            set
            {
                utskickDatum = value;
                Changed();
            }
        }


    }
}
