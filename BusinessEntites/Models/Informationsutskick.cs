﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models
{
    public class Informationsutskick
    {
        public DateTime UtskickDatum { get; set; }
        public List<Alumn> Utskickslista { get; set; }
    }
}
