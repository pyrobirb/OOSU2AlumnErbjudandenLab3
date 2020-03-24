﻿using BusinessEntites.Models.Junction;
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
    class Informationsutskick : INotifyPropertyChanged
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