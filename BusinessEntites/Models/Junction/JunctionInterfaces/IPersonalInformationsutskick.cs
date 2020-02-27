using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction.JunctionInterfaces
{
    public interface IPersonalInformationsutskick
    {
        int PersonalID { get; set; }
        Personal Personal { get; set; }

        int InformationsutskickID { get; set; }
        Informationsutskick Informationsutskick { get; set; }
    }
}
