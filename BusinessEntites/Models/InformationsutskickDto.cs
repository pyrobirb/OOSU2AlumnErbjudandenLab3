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
    public class InformationsutskickDto : IInformationsutskickDto
    {
        [Key]
        public int UtskicksID { get; set; }
        public string UtskicksNamn { get; set; }
        public DateTime UtskickDatum { get; set; }
        public virtual ICollection<AlumnDto> Alumner { get; set; }
        public virtual ICollection<InformationsutskickAlumnDto> InformationsutskickAlumn { get; set; }
        public virtual ICollection<PersonalInformationsutskickDto> PersonalInformationsutskick { get; set; }
        public virtual ICollection<InformationsutskickAktivitetDto> InformationsutskickAktivitet { get; set; }



    }
}
