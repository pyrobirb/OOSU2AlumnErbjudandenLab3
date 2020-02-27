using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Interfaces
{
    public interface IInformationsutskick
    {
        int UtskicksID { get; set; }
        DateTime UtskickDatum { get; set; }

        ICollection<Alumn> Alumner { get; set; }
        ICollection<InformationsutskickAlumn> InformationsutskickAlumn { get; set; }
        ICollection<PersonalInformationsutskick> PersonalInformationsutskick { get; set; }
        ICollection<InformationsutskickAktivitet> InformationsutskickAktivitet { get; set; }


    }
}
