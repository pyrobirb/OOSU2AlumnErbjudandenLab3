﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction.JunctionInterfaces
{
    public interface IPersonalInformationsutskickDTO
    {
        int PersonalID { get; set; }
        PersonalDTO Personal { get; set; }

        int InformationsutskickID { get; set; }
        InformationsutskickDTO Informationsutskick { get; set; }
    }
}
