using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Junction
{
    public class AlumnProgram
    {
        public int AlumnID { get; set; }
        public Alumn Alumn { get; set; }

        public int ProgramID { get; set; }
        public Program Program { get; set; }

    }
}
