using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WPFLayer.Models.Junctions.Interfaces;

namespace WPFLayer.Models.Junctions
{
    [DataContract]
    class InformationsutskickAktivitet : INotifyPropertyChanged, IInformationsutskickAktivitet
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [DataMember]
        public int InformationsutskickID { get; set; }
        [DataMember]
        public virtual Informationsutskick Informationsutskick { get; set; }
        [DataMember]
        public int AktivitetID { get; set; }
        [DataMember]
        public virtual Aktivitet Aktivitet { get; set; }
    }
}
