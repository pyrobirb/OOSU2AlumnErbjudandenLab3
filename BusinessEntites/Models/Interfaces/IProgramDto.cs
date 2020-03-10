using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Interfaces
{
    public interface IProgramDTO
    {
        int ProgramID { get; set; }
        string Namn { get; set; }
        ICollection<AlumnProgramDTO> AlumnProgram { get; set; }

    }
}
