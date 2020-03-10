using AutoMapper;
using BusinessEntites.Models;
using BusinessLayer;
using System;
using System.Collections.Generic;
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

    }
}
