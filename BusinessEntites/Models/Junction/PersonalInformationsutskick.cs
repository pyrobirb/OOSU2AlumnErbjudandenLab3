using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction
{
    public class PersonalInformationsutskick
    {
        public int PersonalID { get; set; }
        public virtual Personal Personal { get; set; }

        public int InformationsutskickID { get; set; }
        public virtual Informationsutskick Informationsutskick { get; set; }
    }
}
