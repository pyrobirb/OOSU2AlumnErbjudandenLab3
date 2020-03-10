using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WPFLayer.Models
{
    [DataContract]
    public class Personal
    {
        [DataMember]
        public int PersonalID { get; set; }
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
