using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Interfaces
{
    public interface IInformationsutskickDto
    {
        int UtskicksID { get; set; }
        string UtskicksNamn { get; set; }
        DateTime UtskickDatum { get; set; }
        ICollection<AlumnDto> Alumner { get; set; }
        ICollection<InformationsutskickAlumnDto> InformationsutskickAlumn { get; set; }
        ICollection<PersonalInformationsutskickDto> PersonalInformationsutskick { get; set; }
        ICollection<InformationsutskickAktivitetDto> InformationsutskickAktivitet { get; set; }


    }
}
