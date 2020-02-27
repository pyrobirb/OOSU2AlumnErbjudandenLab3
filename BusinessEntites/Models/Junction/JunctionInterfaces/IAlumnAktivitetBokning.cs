using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction.JunctionInterfaces
{
    public interface IAlumnAktivitetBokning
    {
        int AlumnID { get; set; }
        Alumn Alumn { get; set; }

        int AktivitetID { get; set; }
        Aktivitet Aktivitet { get; set; }
    }
}
