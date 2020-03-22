using AutoMapper;
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
using WPFLayer.ViewModel;

namespace WPFLayer.Models
{
    [DataContract]
    public class Alumn : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [DataMember]
        private int användarID;
        [DataMember]
        private string användarnamn;
        [DataMember]
        private string lösenord;
        [DataMember]
        private string förnamn;
        [DataMember]
        private string efternamn;

        [DataMember]
        public virtual ICollection<AlumnProgramDTO> AlumnProgram { get; set; }
        [DataMember]

        public virtual ICollection<AlumnKompetensDTO> AlumnKompetens { get; set; }
        [DataMember]

        public virtual ICollection<InformationsutskickAlumnDTO> InformationsutskickAlumn { get; set; }
        [DataMember]

        public virtual ICollection<AlumnAktivitetBokningDTO> AlumnAktivitet { get; set; }
        [DataMember]

        public virtual ICollection<AlumnMaillistaDTO> AlumnMaillistor { get; set; }

        public int AnvändarID
        {
            get { return användarID; }
            set { användarID = value; }
        }

        public string Användarnamn
        {
            get { return användarnamn; }
            set
            {
                användarnamn = value;
                Changed();
            }
        }

        public string Lösenord
        {
            get { return lösenord; }
            set
            {
                lösenord = value;
                Changed();
            }
        }

        public string Förnamn
        {
            get { return förnamn; }
            set
            {
                förnamn = value;
                Changed();
            }
        }

        public string Efternamn
        {
            get { return efternamn; }
            set
            {
                efternamn = value;
                Changed();
            }
        }

        public static ObservableCollection<Alumn> HämtaAlumner()
        {
            BusinessManager bm = new BusinessManager();
            var mapper = MapperConfig.GetMapper();

            ObservableCollection<Alumn> Hämtadealumner = new ObservableCollection<Alumn>();

            foreach (var item in bm.HämtaAllaAlumner())
            {
                Hämtadealumner.Add(mapper.Map<AlumnDTO, Alumn>(item));
            }

            return Hämtadealumner;
        }

    }
}
