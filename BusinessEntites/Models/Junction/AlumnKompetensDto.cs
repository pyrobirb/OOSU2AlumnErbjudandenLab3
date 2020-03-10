using BusinessEntites.Models.Junction.JunctionInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction
{
    public class AlumnKompetensDto : IAlumnKompetensDto
    {
        public int AlumnID { get; set; }
        public virtual AlumnDto Alumn { get; set; }

        public int KompetensID { get; set; }
        public virtual KompetensDto Kompetens { get; set; }
    }
}
