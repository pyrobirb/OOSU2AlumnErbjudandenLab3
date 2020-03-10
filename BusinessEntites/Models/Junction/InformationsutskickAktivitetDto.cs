using BusinessEntites.Models.Junction.JunctionInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction
{
    public class InformationsutskickAktivitetDto : IInformationsutskickAktivitetDto
    {
        public int InformationsutskickID { get; set; }
        public virtual InformationsutskickDto Informationsutskick { get; set; }

        public int AktivitetID { get; set; }
        public virtual AktivitetDto Aktivitet { get; set; }
    }
}
