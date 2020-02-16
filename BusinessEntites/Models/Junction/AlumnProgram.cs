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
        public virtual Alumn Alumn { get; set; }

        public int ProgramID { get; set; }
        public virtual Program Program { get; set; }

    }
}
