using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WPFLayer.Models
{
    [DataContract]
    class Kompetens : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [DataMember]
        private int kompetensID;
        [DataMember]
        private string beskrivning;
        [DataMember]
        public virtual ICollection<AlumnKompetensDTO> AlumnKompetens { get; set; }

        public int KompetensID
        {
            get { return kompetensID; }
            set { kompetensID = value; }
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

    }
}
