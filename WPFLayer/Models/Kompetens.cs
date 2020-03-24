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
    public class Kompetens : INotifyPropertyChanged
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

        internal static ObservableCollection<Kompetens> HämtaAlumnensKompetenser()
        {
            BusinessManager bm = new BusinessManager();
            var mapper = MapperConfig.GetMapper();
            ObservableCollection<Kompetens> temp = new ObservableCollection<Kompetens>();

            foreach (var item in bm.HämtaKompetenserFörAlumn(GLOBALSWPF.AktuellAlumn))
            {
                temp.Add(mapper.Map<KompetensDTO, Kompetens>(item));
            }

            return temp;
        }
    }
}
