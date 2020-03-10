using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction.JunctionInterfaces
{
    public interface IAlumnKompetensDTO
    {
        int AlumnID { get; set; }
        AlumnDTO Alumn { get; set; }

        int KompetensID { get; set; }
        KompetensDTO Kompetens { get; set; }
    }
}
