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
using WPFLayer.Models.Junctions.Interfaces;

namespace WPFLayer.Models.Junctions
{
    [DataContract]
    class AlumnMaillista : INotifyPropertyChanged, IAlumnMaillista
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [DataMember]
        public int AlumnID { get; set; }
        [DataMember]
        public virtual Alumn Alumn { get; set; }
        [DataMember]
        public int MaillistaID { get; set; }
        [DataMember]
        public virtual Maillista Maillista { get; set; }

        internal static void SkapaAlumnMaillista(ObservableCollection<Alumn> utvaldaRedigeraAlumnerMaillista)
        {
            BusinessManager bm = new BusinessManager();
            var mapper = MapperConfig.GetMapper();

            foreach (Alumn alumn in utvaldaRedigeraAlumnerMaillista)
            {
                AlumnMaillista alumnMaillista = new AlumnMaillista()
                {
                    MaillistaID = bm.HämtaSenasteMaillista().MaillistaID,
                    AlumnID = (bm.HämtaAlumnMedID(alumn.AnvändarID)).AnvändarID
                };
                bm.LäggTillAlumnMaillista(mapper.Map<AlumnMaillista, AlumnMaillistaDTO>(alumnMaillista));
            }
            bm.Commit();

        }
    }
}
