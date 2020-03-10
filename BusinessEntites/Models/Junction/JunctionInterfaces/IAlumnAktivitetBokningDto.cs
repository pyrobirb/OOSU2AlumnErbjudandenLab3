using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction.JunctionInterfaces
{
    public interface IAlumnAktivitetBokningDTO
    {
        int AlumnID { get; set; }
        AlumnDTO Alumn { get; set; }

        int AktivitetID { get; set; }
        AktivitetDTO Aktivitet { get; set; }
    }
}
