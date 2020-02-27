using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction.JunctionInterfaces
{
    public interface IInformationsutskickAktivitet
    {
        int InformationsutskickID { get; set; }
        Informationsutskick Informationsutskick { get; set; }

        int AktivitetID { get; set; }
        Aktivitet Aktivitet { get; set; }
    }
}
