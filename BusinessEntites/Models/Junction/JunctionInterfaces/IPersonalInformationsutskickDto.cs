using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction.JunctionInterfaces
{
    public interface IPersonalInformationsutskickDto
    {
        int PersonalID { get; set; }
        PersonalDto Personal { get; set; }

        int InformationsutskickID { get; set; }
        InformationsutskickDto Informationsutskick { get; set; }
    }
}
