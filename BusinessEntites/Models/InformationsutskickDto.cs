using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntites.Models.Interfaces;
using BusinessEntites.Models.Junction;

namespace BusinessEntites.Models
{
    public class InformationsutskickDTO : IInformationsutskickDTO
    {
        [Key]
        public int UtskicksID { get; set; }
        public string UtskicksNamn { get; set; }
        public DateTime UtskickDatum { get; set; }
        public virtual ICollection<AlumnDTO> Alumner { get; set; }
        public virtual ICollection<InformationsutskickAlumnDTO> InformationsutskickAlumn { get; set; }
        public virtual ICollection<PersonalInformationsutskickDTO> PersonalInformationsutskick { get; set; }
        public virtual ICollection<InformationsutskickAktivitetDTO> InformationsutskickAktivitet { get; set; }



    }
}
