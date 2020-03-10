using BusinessEntites.Models.Junction.JunctionInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction
{
    public class InformationsutskickAlumnDTO : IInformationsutskickAlumnDTO
    {
        public int AlumnID { get; set; }
        public virtual AlumnDTO Alumn { get; set; }

        public int InformationsutskickID { get; set; }
        public virtual InformationsutskickDTO Informationsutskick { get; set; }
    }
}
