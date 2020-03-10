using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction.JunctionInterfaces
{
    public interface IAlumnProgramDTO
    {
        int AlumnID { get; set; }
        AlumnDTO Alumn { get; set; }

        int ProgramID { get; set; }
        ProgramDTO Program { get; set; }
    }
}
