using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Interfaces
{
    public interface IInformationsutskickDTO
    {
        int UtskicksID { get; set; }
        string UtskicksNamn { get; set; }
        DateTime UtskickDatum { get; set; }
        ICollection<AlumnDTO> Alumner { get; set; }
        ICollection<InformationsutskickAlumnDTO> InformationsutskickAlumn { get; set; }
        ICollection<PersonalInformationsutskickDTO> PersonalInformationsutskick { get; set; }
        ICollection<InformationsutskickAktivitetDTO> InformationsutskickAktivitet { get; set; }


    }
}
