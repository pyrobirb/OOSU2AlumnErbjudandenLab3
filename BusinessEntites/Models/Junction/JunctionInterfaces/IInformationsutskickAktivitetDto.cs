using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction.JunctionInterfaces
{
    public interface IInformationsutskickAktivitetDTO
    {
        int InformationsutskickID { get; set; }
        InformationsutskickDTO Informationsutskick { get; set; }

        int AktivitetID { get; set; }
        AktivitetDTO Aktivitet { get; set; }
    }
}
