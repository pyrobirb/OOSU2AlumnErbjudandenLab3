using BusinessEntites.Models.Junction.JunctionInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction
{
    public class AlumnKompetens : IAlumnKompetens
    {
        public int AlumnID { get; set; }
        public virtual Alumn Alumn { get; set; }

        public int KompetensID { get; set; }
        public virtual Kompetens Kompetens { get; set; }
    }
}
