using BusinessEntites.Models.Junction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Models.Interfaces
{
    interface IKompetens
    {
        int KompetensID { get; set; }
        string Beskrivning { get; set; }

        ICollection<AlumnKompetens> AlumnKompetens { get; set; }

    }
}
