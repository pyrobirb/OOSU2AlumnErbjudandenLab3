using BusinessEntites.Models.Junction.JunctionInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction
{
    public class AlumnProgramDTO : IAlumnProgramDTO
    {
        public int AlumnID { get; set; }
        public virtual AlumnDTO Alumn { get; set; }

        public int ProgramID { get; set; }
        public virtual ProgramDTO Program { get; set; }

    }
}
