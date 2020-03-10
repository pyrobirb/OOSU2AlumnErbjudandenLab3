using BusinessEntites.Models.Junction.JunctionInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction
{
    public class InformationsutskickAktivitetDTO : IInformationsutskickAktivitetDTO
    {
        public int InformationsutskickID { get; set; }
        public virtual InformationsutskickDTO Informationsutskick { get; set; }

        public int AktivitetID { get; set; }
        public virtual AktivitetDTO Aktivitet { get; set; }
    }
}
