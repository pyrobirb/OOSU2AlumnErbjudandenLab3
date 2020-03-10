using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction.JunctionInterfaces
{
    public interface IAlumnAktivitetBokningDto
    {
        int AlumnID { get; set; }
        AlumnDto Alumn { get; set; }

        int AktivitetID { get; set; }
        AktivitetDto Aktivitet { get; set; }
    }
}
