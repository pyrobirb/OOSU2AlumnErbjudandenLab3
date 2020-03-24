using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WPFLayer.Models.Junktions
{
    [DataContract]
    class AlumnAktivitetsBokning : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [DataMember]
        private int alumnID;

        public int AlumnID
        {
            get { return alumnID; }
            set { alumnID = value; }
        }

        [DataMember]
        public virtual Alumn Alumn { get; set; }

        [DataMember]
        private int aktivitetsID;

        public int AktivitetID
        {
            get { return aktivitetsID; }
            set { aktivitetsID = value; }
        }

        [DataMember]
        public virtual Aktivitet Aktivitet { get; set; }

    }
}
