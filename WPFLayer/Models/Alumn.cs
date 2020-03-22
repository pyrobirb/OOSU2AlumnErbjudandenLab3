﻿using AutoMapper;
using BusinessEntites.Models;
using BusinessEntites.Models.Junction;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WPFLayer.ViewModel;

namespace WPFLayer.Models
{
    [DataContract]
    public class Alumn
    {
        [DataMember]
        public int AnvändarID { get; set; }
        [DataMember]
        public string Användarnamn { get; set; }

        [DataMember]
        public string Lösenord { get; set; }
        [DataMember]
        public string Förnamn { get; set; }
        [DataMember]
        public string Efternamn { get; set; }

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

    
        public static ObservableCollection<Alumn> HämtaAlumner()
        {
            BusinessManager bm = new BusinessManager();
            var mapper = MapperConfig.GetMapper();

            ObservableCollection<Alumn> alumner = new ObservableCollection<Alumn>();

            var hämtadeAlumner = bm.HämtaAllaAlumner(mapper.Map<Alumn, AlumnDTO>(alumn));

            //bm.LäggTillAlumn(mapper.Map<Alumn, AlumnDTO>(alumn));
        }

    }
}
