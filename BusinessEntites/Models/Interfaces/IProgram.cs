using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Interfaces
{
    interface IProgram
    {
        string ProgramID { get; set; }
        string Namn { get; set; }
    }
}
