using BusinessEntites.Models.Junction.JunctionInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction
{
    public class AlumnAktivitetBokningDTO : IAlumnAktivitetBokningDTO
    {
        public int AlumnID { get; set; }
        public virtual AlumnDTO Alumn { get; set; }

        public int AktivitetID { get; set; }
        public virtual AktivitetDTO Aktivitet { get; set; }

    }
}
