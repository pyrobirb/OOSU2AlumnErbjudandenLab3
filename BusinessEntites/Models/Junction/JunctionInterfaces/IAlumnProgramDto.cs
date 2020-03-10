using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction.JunctionInterfaces
{
    public interface IAlumnProgramDto
    {
        int AlumnID { get; set; }
        AlumnDto Alumn { get; set; }

        int ProgramID { get; set; }
        ProgramDto Program { get; set; }
    }
}
