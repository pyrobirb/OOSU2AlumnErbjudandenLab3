using BusinessEntites.Models.Junction.JunctionInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction
{
    public class PersonalInformationsutskickDTO : IPersonalInformationsutskickDTO
    {
        public int PersonalID { get; set; }
        public virtual PersonalDTO Personal { get; set; }

        public int InformationsutskickID { get; set; }
        public virtual InformationsutskickDTO Informationsutskick { get; set; }
    }
}
