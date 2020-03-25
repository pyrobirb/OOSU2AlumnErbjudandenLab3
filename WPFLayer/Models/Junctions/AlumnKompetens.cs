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
    class AlumnKompetens : INotifyPropertyChanged, IAlumnKompetens
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [DataMember]
        private int alumnID;
        [DataMember]
        public virtual Alumn Alumn { get; set; }
        [DataMember]
        private int kompetensID;
        [DataMember]
        public virtual Kompetens Kompetens { get; set; }

        public int KompetensID
        {
            get { return kompetensID; }
            set { kompetensID = value; }
        }

        public int AlumnID
        {
            get { return alumnID; }
            set { alumnID = value; }
        }



    }
}
