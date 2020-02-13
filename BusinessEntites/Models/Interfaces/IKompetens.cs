using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Interfaces
{
    interface IKompetens
    {
        string KompetensID { get; set; }
        string Beskrivning { get; set; }
    }
}
