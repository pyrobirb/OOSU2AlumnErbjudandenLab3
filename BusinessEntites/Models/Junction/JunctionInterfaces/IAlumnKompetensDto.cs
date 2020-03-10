using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction.JunctionInterfaces
{
    public interface IAlumnKompetensDto
    {
        int AlumnID { get; set; }
        AlumnDto Alumn { get; set; }

        int KompetensID { get; set; }
        KompetensDto Kompetens { get; set; }
    }
}
