using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WPFLayer.Models.Junctions
{
    [DataContract]
    class PersonalInformationsutskick : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [DataMember]
        public int PersonalID { get; set; }
        [DataMember]
        public virtual Personal Personal { get; set; }
        [DataMember]
        public int InformationsutskickID { get; set; }
        [DataMember]
        public virtual Informationsutskick Informationsutskick { get; set; }
    }
}
