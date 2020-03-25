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
    public class Maillista : INotifyPropertyChanged, IMaillista
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [DataMember]
        private int maillistaID;

        internal static ObservableCollection<Maillista> HämtaAllaMaillistor()
        {
            BusinessManager bm = new BusinessManager();
            var mapper = MapperConfig.GetMapper();
            ObservableCollection<Maillista> x = new ObservableCollection<Maillista>();

            foreach (var item in bm.HämtaAllaMaillistor())
            {
                x.Add(mapper.Map<MaillistaDTO, Maillista>(item));
            }
            return x;
        }

        [DataMember]
        private string maillistaNamn;
        [DataMember]
        public virtual ICollection<AlumnMaillistaDTO> AlumnMaillistor { get; set; }

        public int MaillistaID
        {
            get { return maillistaID; }
            set { maillistaID = value; }
        }

        public string MaillistaNamn
        {
            get { return maillistaNamn; }
            set
            {
                maillistaNamn = value;
                Changed();
            }
        }

        internal static List<Alumn> HämtaAlumnerFrånMaillista(Maillista maillista)
        {
            BusinessManager bm = new BusinessManager();
            var mapper = MapperConfig.GetMapper();
            List<Alumn> x = new List<Alumn>();

            foreach (var item in bm.HämtaAlumnerFrånMailLista(maillista.MaillistaID))
            {
                x.Add(mapper.Map<AlumnDTO, Alumn>(item));
            }
            return x;

        }

        internal static void SkapaMailLista(string namnMaillista)
        {
            BusinessManager bm = new BusinessManager();
            var mapper = MapperConfig.GetMapper();

            Maillista maillista = new Maillista()
            {
                MaillistaNamn = namnMaillista,
                AlumnMaillistor = new List<AlumnMaillistaDTO>()
            };
            bm.LäggTillMaillista(mapper.Map<Maillista, MaillistaDTO>(maillista));
            bm.Commit();








        }
    }
}
