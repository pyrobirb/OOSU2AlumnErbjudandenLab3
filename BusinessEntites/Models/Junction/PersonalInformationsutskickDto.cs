using BusinessEntites.Models.Junction.JunctionInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction
{
    public class PersonalInformationsutskickDto : IPersonalInformationsutskickDto
    {
        public int PersonalID { get; set; }
        public virtual PersonalDto Personal { get; set; }

        public int InformationsutskickID { get; set; }
        public virtual InformationsutskickDto Informationsutskick { get; set; }
    }
}
