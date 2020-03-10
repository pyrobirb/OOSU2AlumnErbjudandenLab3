using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction.JunctionInterfaces
{
    public interface IInformationsutskickAktivitetDto
    {
        int InformationsutskickID { get; set; }
        InformationsutskickDto Informationsutskick { get; set; }

        int AktivitetID { get; set; }
        AktivitetDto Aktivitet { get; set; }
    }
}
