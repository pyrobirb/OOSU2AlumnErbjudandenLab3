using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntites.Models.Interfaces;

namespace BusinessEntites.Models
{
    public class Kompetens : IKompetens
    {
        public string KompetensID { get; set; }
        public string Beskrivning { get; set; }
    }
}
