using BusinessEntites.Models.Junction.JunctionInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction
{
    public class InformationsutskickAlumn : IInformationsutskickAlumn
    {
        public int AlumnID { get; set; }
        public virtual Alumn Alumn { get; set; }

        public int InformationsutskickID { get; set; }
        public virtual Informationsutskick Informationsutskick { get; set; }
    }
}
