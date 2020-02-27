using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction.JunctionInterfaces
{
    public interface IAlumnProgram
    {
        int AlumnID { get; set; }
        Alumn Alumn { get; set; }

        int ProgramID { get; set; }
        Program Program { get; set; }
    }
}
