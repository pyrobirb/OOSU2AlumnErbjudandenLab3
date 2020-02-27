using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction.JunctionInterfaces
{
    public interface IInformationsutskickAlumn
    {
        int AlumnID { get; set; }
        Alumn Alumn { get; set; }

        int InformationsutskickID { get; set; }
        Informationsutskick Informationsutskick { get; set; }
    }
}

