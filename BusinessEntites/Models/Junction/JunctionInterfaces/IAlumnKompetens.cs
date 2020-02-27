using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction.JunctionInterfaces
{
    public interface IAlumnKompetens
    {
        int AlumnID { get; set; }
        Alumn Alumn { get; set; }

        int KompetensID { get; set; }
        Kompetens Kompetens { get; set; }
    }
}
